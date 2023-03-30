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
        public Guid GetEmployeeId(string empId)
        {
            return _dbContext.Users.FirstOrDefault(user => user.EmpID == empId).Id;
        }

        public User? GetUserById(string userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == new Guid(userId));
        }

        public User? GetUserByEmployeeId(string employeeId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.EmpID == employeeId);
        }

        public string GetFullName(Guid id)
        {
            string fullName;
            User user = _dbContext.Users.FirstOrDefault(user => user.Id == id);
            fullName = $"{user.FirstName} {user.LastName} {user.MiddleName}";
            return fullName;
        }
    }
}
