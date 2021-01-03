using System;
using DAWProject.Models;
using DAWProject.Models.DTOs;

namespace DAWProject.Services.UserService
{
    public interface IUserService
    {
        UserResponseDTO Authenticate(UserRequestDTO model);

        void Create(User user);
        User GetById(Guid userId);
    }
}
