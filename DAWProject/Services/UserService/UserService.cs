using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DAWProject.Helpers;
using DAWProject.Models;
using DAWProject.Models.Base;
using DAWProject.Models.DTOs;
using DAWProject.Repositories.UserRepository;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace DAWProject.Services.UserService
{
    public class UserService: IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly IUserRepository _userRepository;
        
        public UserService(IOptions<AppSettings> appSettings, IUserRepository userRepository)
        {
            _appSettings = appSettings.Value;
            _userRepository = userRepository;
        }

        public UserResponseDTO Authenticate(UserRequestDTO model)
        {
            var user = _userRepository.FindByCredentials(model.Username, model.Password);

            if (user == null) return null;

            var token = GenerateUserJwtToken(user);

            return new UserResponseDTO(user, token);
        }

        private string GenerateUserJwtToken(IBaseEntity entity)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", entity.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public void Create(User user)
        {
            _userRepository.Create(user);
            _userRepository.Save();
        }

        public User GetById(Guid userId)
        {
            return _userRepository.FindById(userId);
        }
    }
}
