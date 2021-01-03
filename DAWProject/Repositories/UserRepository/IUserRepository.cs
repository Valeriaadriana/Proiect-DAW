using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByCredentials(string username, string password);
    }
}