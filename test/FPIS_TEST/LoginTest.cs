using FPIS;
using FPIS.Models;
using FPIS.Utils;

namespace FPIS_TEST
{
    [TestClass]
    public class LoginTest
    {
        Login obj;
        public LoginTest()
        {
            obj = new Login();
        }
        [TestMethod]
        public void TestTestUserProvidedData()
        {
            string userInput = "Kofi";
           // bool testResultIsTrue = obj.TestUserProvidedData(userInput);
           // Assert.IsTrue(testResultIsTrue);
        }

        [TestMethod]
        public void TestAuthenticateUser()
        {
            string employeeId = "1";
            string password = Utils.HashPassword("savage");
         //   LoginAuth authToken = obj.TestAuthenticateUser(employeeId, password);
          //  Assert.AreEqual(authToken, LoginAuth.AUTH_PASS);
        }
    }
}
