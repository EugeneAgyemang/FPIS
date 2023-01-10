using FPIS.Models;
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
            if (!(dataProvided))
            {
                MaterialMessageBox.Show("Kindly provide your Employee ID", "Login Failed");
                txtEmpId.Focus();
                return;
            }
            dataProvided = UserProvidedData(password);
            if (!(dataProvided))
            {
                MaterialMessageBox.Show("Kindly provide your password", "Login Failed");
                txtPassword.Focus();
                return;
            }

            var db = new AppDbContext();
            // Search for user using their employee id and their password
            var resultSet = db.Users.Where(user => (user.EmpID == employeeId) && (user.Password == password));
            if(resultSet.Count() == 0 )
            {
                MaterialMessageBox.Show("Invalid login credentials", "Login Failed");
                // The called function currently only clears the password
                ResetFields();
                return;
            }
            MaterialMessageBox.Show("Welcome", "Login Passed");
        }

        private bool UserProvidedData(string userInput)
        {
            string userInputTrimmed = userInput.Trim();
            // Check whether there's no content in the input field
            bool dataProvided = (!(userInputTrimmed == string.Empty));
            return dataProvided;
        }
        private void ResetFields()
        {
            txtPassword.Text = string.Empty;
        }
    }
}
