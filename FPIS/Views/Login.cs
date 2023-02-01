using FPIS.Contracts;
using FPIS.Models;
using FPIS.Services;
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

            // Seperately check the username and passwords to show different error messages
            bool dataProvided = UserProvidedData(employeeId);
            if (!dataProvided)
            {
                MaterialMessageBox.Show("Kindly provide your Employee ID", "Login Failed");
                txtEmpId.Focus();
            }
            dataProvided = UserProvidedData(password);
            if (!dataProvided)
            {
                MaterialMessageBox.Show("Kindly provide your password", "Login Failed");
                txtPassword.Focus();
            }

            AppDbContext appDbContext = new();
            try
            {
                LoginService loginService = new(appDbContext);
                LoginAuth loginResults = loginService.AuthenticateUser(employeeId, password);
                if (loginResults == LoginAuth.AUTH_FAIL)
                {
                    MaterialMessageBox.Show("Invalid login credentials", "Login Failed");
                    ResetFields();
                }
                else
                {
                    MaterialMessageBox.Show("Welcome", "Login Passed");
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message);
            }
            finally
            {
                appDbContext.Dispose();
            }
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
