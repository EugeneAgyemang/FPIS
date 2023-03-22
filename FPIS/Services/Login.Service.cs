using FPIS.Models;
using FPIS.Utils;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class LoginService
    {
        AppDbContext appDbContext;
        public LoginService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public LoginAuth AuthenticateUser(string employeeID, string password)
        {
            string hashPassword = Utils.Utils.HashPassword(password);
            var resultSet = appDbContext.Users.FirstOrDefault(user => user.EmpID == employeeID && user.Password == hashPassword);
            if (resultSet == null)
            {
                return LoginAuth.AUTH_FAIL;
            }
            return LoginAuth.AUTH_PASS;
        }
        public string GetFullName(string empId)
        {
            string fullName;
            User user = appDbContext.Users.FirstOrDefault(user => user.EmpID == empId);
            fullName = $"{user.FirstName} {user.LastName} {user.MiddleName}";
            return fullName;
        }
    }
}
