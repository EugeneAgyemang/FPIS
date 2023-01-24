using FPIS.Models;
using FPIS.Utils;
using FPIS.Views;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            btnLogin.Click += LogUserIn;
        }

        private void LogUserIn(object? sender, EventArgs e)
        {
            string employeeId = txtEmpId.Text;
            string password = txtPassword.Text;
            LoginAuth authToken = AuthenticateUser(employeeId, password);
            switch (authToken)
            {
                case LoginAuth.NO_USERNAME:
                    MaterialMessageBox.Show("Kindly provide your Employee ID", "Login Failed");
                    txtEmpId.Focus();
                    break;
                case LoginAuth.NO_PASSWORD:
                    MaterialMessageBox.Show("Kindly provide your password", "Login Failed");
                    txtPassword.Focus();
                    break;
                case LoginAuth.AUTH_FAIL:
                    MaterialMessageBox.Show("Invalid login credentials", "Login Failed");
                    // The called function currently only clears the password
                    ResetFields();
                    break;
                case LoginAuth.AUTH_PASS:
                    MaterialMessageBox.Show("Welcome", "Login Passed");
                    break;
            }
        }

        public LoginAuth AuthenticateUser(string employeeId, string password)
        {
            // Seperately check the username and passwords to show different error messages
            bool dataProvided = UserProvidedData(employeeId);
            if (!dataProvided)
            {
                return LoginAuth.NO_USERNAME;
            }
            dataProvided = UserProvidedData(password);
            if (!dataProvided)
            {
                return LoginAuth.NO_PASSWORD;
            }

            var db = new AppDbContext();
            // Search for user using their employee id and their password
            var resultSet = db.Users.Where(user => (user.EmpID == employeeId) && (user.Password == password));
            if (resultSet.Count() == 0)
            {
                return LoginAuth.AUTH_FAIL;
            }
            return LoginAuth.AUTH_PASS;
        }

        public bool UserProvidedData(string userInput)
        {
            string userInputTrimmed = userInput.Trim();
            // Check whether there's no content in the input field
            bool isDataProvided = (!(userInputTrimmed == string.Empty));
            return isDataProvided;
        }
        public void ResetFields()
        {
            txtPassword.Text = string.Empty;
        }
    }
}
