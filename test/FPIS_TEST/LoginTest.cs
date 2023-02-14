using FPIS;
using FPIS.Models;
using FPIS.Utils;

namespace FPIS_TEST
{
    [TestClass]
    public class LoginTest
    {
        Login login;
        [TestInitialize]
        public void InitializeTest()
        {
            login = new Login();
        }

        [TestMethod]
        public void TestUserProvidedData()
        {
            string userInput = "Some data";

            bool expected = login.UserProvidedData(userInput);

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestResetFields()
        {
            login.txtPassword.Text = "Clear me";

            login.ResetFields();
            string expectedValue = login.txtPassword.Text;

            Assert.AreEqual(expectedValue, string.Empty);


        }
    }
}
