using System.Linq;
using DAWProject.Data;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DawAppContext dbContext) : base(dbContext)
        {
        }

        public User FindByCredentials(string username, string password)
        {
            return _table.SingleOrDefault(user => user.Username.Equals(username) && user.Password.Equals(password));
        }
    }
}