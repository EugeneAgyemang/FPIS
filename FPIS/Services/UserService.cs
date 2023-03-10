using FPIS.Models;
using System.Linq.Expressions;

namespace FPIS.Services
{
    internal class UserService
    {
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Constructor to initialize a new `UserService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

        public List<User> GetAllUsersWithoutId(Guid userId)
        {
            return _dbContext.Users.Where(u => u.Id != userId).ToList();
        }

        public User? GetUserById(Guid userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == userId);
        }

        public User? GetUserById(string userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == new Guid(userId));
        }
    }
}
