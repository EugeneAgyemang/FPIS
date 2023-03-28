using FPIS.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
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

        public List<Models.User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

        public List<Models.User> GetAllUsersWithoutId(Guid userId)
        {
            return _dbContext.Users.Where(u => u.Id != userId).ToList();
        }

        public Models.User? GetUserById(Guid userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == userId);
        }

        public Models.User? GetUserById(string userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == new Guid(userId));
        }
        public string GetFullName(Guid id)
        {
            string fullName;
            Models.User user = _dbContext.Users.FirstOrDefault(user => user.Id == id);
            fullName = $"{user.FirstName} {user.LastName} {user.MiddleName}";
            return fullName;
        }
        public Models.User GetUserByEmpId(string empId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.EmpID == empId);
        }
        public string GetEmployeeIdByGuid(Guid id)
        {
            return (_dbContext.Users.
                Where(user => user.Id == id).
                FirstOrDefault()).EmpID;
        }
    }
}
