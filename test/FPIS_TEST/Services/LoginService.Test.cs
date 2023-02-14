using FPIS.Models;
using FPIS.Services;
using FPIS.Utils;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS_TEST.Services
{
    [TestClass]
    public class LoginServiceTest
    {
        [TestMethod]
        public void TestAuthenticateUserPassed()
        {
            var users = new List<User>
            {
                new User{ EmpID = "1", Password = Utils.HashPassword("12345678") },
                new User{ EmpID = "2", Password = Utils.HashPassword("87654321")}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<User>>();
            mockSet.As<IQueryable<User>>().Setup(mock => mock.Expression).Returns(users.Expression);
            mockSet.As<IQueryable<User>>().Setup(mock => mock.Provider).Returns(users.Provider);
            mockSet.As<IQueryable<User>>().Setup(mock => mock.ElementType).Returns(users.ElementType);
            mockSet.As<IQueryable<User>>().Setup(mock => mock.GetEnumerator()).Returns(users.GetEnumerator());

            var mockDbContext = new Mock<AppDbContext>();
            mockDbContext.Setup(mock => mock.Users).Returns(mockSet.Object);

            LoginService loginService = new(mockDbContext.Object);
            LoginAuth expected = loginService.AuthenticateUser("1", "12345678");

            Assert.AreEqual(expected, LoginAuth.AUTH_PASS);

        }

        [TestMethod]
        public void TestAuthenticateUserFailed()
        {
            var users = new List<User>()
            {
                new User{ EmpID = "1", Password = Utils.HashPassword("12345678") },
                new User{ EmpID = "2", Password = Utils.HashPassword("87654321")}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<User>>();
            mockSet.As<IQueryable<User>>().Setup(mock => mock.Provider).Returns(users.Provider);
            mockSet.As<IQueryable<User>>().Setup(mock => mock.ElementType).Returns(users.ElementType);
            mockSet.As<IQueryable<User>>().Setup(mock => mock.Expression).Returns(users.Expression);
            mockSet.As<IQueryable<User>>().Setup(mock => mock.GetEnumerator()).Returns(users.GetEnumerator());

            var mockDbContext = new Mock<AppDbContext>();
            mockDbContext.Setup(mock => mock.Users).Returns(mockSet.Object);

            LoginService loginService = new(mockDbContext.Object);
            LoginAuth expected = loginService.AuthenticateUser("1", "wrong password");

            Assert.AreEqual(expected, LoginAuth.AUTH_FAIL);


        }
    }
}
