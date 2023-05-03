using FPIS.Models;
using FPIS.Views;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS
{
    public partial class Register : MaterialForm
    {
        bool _isDataValid = true;

        // 3 characters or more, no numbers and special characters
        readonly string nameRegexPattern = "^[a-zA-Z]{3,}$";
        readonly string passwordRegexPattern = "^.{6,}$"; // very minimal password enforcement
        public Register()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            labelEmployeeId.ForeColor = Color.Red;
            labelFirstName.ForeColor = Color.Red;
            labelLastName.ForeColor = Color.Red;
            labelPassword.ForeColor = Color.Red;
            labelConfirmPassword.ForeColor = Color.Red;
            LoadDesignations();
        }

        private void ClearErrorLabels()
        {
            labelEmployeeId.Text = "";
            labelFirstName.Text = "";
            labelLastName.Text = "";
            labelPassword.Text = "";
            labelConfirmPassword.Text = "";
        }

        private void ValidateEmployeeId()
        {
            string employeeId = materialTextBoxEmployeeId.Text.Trim();

            if (employeeId.Length == 0)
            {
                labelEmployeeId.Text = "Employee ID is required!";
                _isDataValid = false;
                return;
            }

            AppDbContext dbContext = new();
            var user = dbContext.Users.FirstOrDefault(user => user.EmpID == employeeId);
            dbContext.Dispose();

            if (user != null)
            {
                _isDataValid = false;
                labelEmployeeId.Text = "Employee ID is already used. Please change it.";
                return;
            }

        }

        private void ValidateFirstName()
        {
            string firstName = materialTextBoxFirstName.Text.Trim();

            if (firstName.Length == 0)
            {
                labelFirstName.Text = "First name is required!";
                _isDataValid = false;
                return;
            }

            Regex regex = new(nameRegexPattern);

            if (!regex.IsMatch(firstName))
            {
                labelFirstName.Text = "First name cannot have numbers.";
                _isDataValid = false;
                return;
            }
        }

        private void ValidateLastName()
        {
            string lastName = materialTextBoxLastName.Text.Trim();

            if (lastName.Length == 0)
            {
                labelLastName.Text = "Last name is required!";
                _isDataValid = false;
                return;
            }

            Regex regex = new(nameRegexPattern);

            if (!regex.IsMatch(lastName))
            {
                labelLastName.Text = "Last name cannot have numbers.";
                _isDataValid = false;
                return;
            }
        }

        private void ValidatePassword()
        {
            string password = materialTextBoxPassword.Text.Trim();

            if (password.Length == 0)
            {
                labelPassword.Text = "Password is required!";
                _isDataValid = false;
                return;
            }

            Regex passwordRegex = new(passwordRegexPattern);

            if (!passwordRegex.IsMatch(password))
            {
                labelPassword.Text = "Password should be at least 6 characters.";
                _isDataValid = false;
                return;
            }
        }

        private void ValidateConfirmedPassword()
        {
            string password = materialTextBoxPassword.Text.Trim();
            string confirmedPassword = materialTextBoxConfirmedPassword.Text.Trim();

            if (confirmedPassword.Length == 0)
            {
                labelConfirmPassword.Text = "Confirmed password is required!";
                _isDataValid = false;
                return;
            }

            if (password != confirmedPassword)
            {
                labelConfirmPassword.Text = "Confirmed password must be equal to password.";

                _isDataValid = false;
                return;
            }
        }

        private void ValidateInputs()
        {
            ValidateEmployeeId();
            ValidateFirstName();
            ValidateLastName();
            ValidatePassword();
            ValidateConfirmedPassword();
        }

        private void RegisterUser()
        {
            btnRegister.Enabled = false;
            var designation = new AppDbContext().Designations.Where(design => 
            design.DesignationName == materialComboBoxDesignation.Text).Single();
            User user = new()
            {
                EmpID = materialTextBoxEmployeeId.Text,
                FirstName = materialTextBoxFirstName.Text,
                LastName = materialTextBoxLastName.Text,
                MiddleName = materialTextBoxMiddleName.Text,
                Password = Utils.Utils.HashPassword(materialTextBoxConfirmedPassword.Text),
                DesignationId = designation.Id
        };

            try
            {
                AppDbContext dbContext = new();
                dbContext.Users.Add(user);
                dbContext.SaveChanges();

                MessageBox.Show(
                    $"{user.FirstName} is successfully registered.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                dbContext.Dispose();
                ResetControls();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating user: {ex}");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                btnRegister.Enabled = true;
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            _isDataValid = true;

            ClearErrorLabels();
            ValidateInputs();

            if (!_isDataValid)
            {
                MessageBox.Show(
                    "You have some invalid inputs",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult userOption = Utils.Utils.ShowMessageBox("Do you wish to proceed with details you provided?"
                , "Confirm Registration"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if(userOption == DialogResult.No)
            {
                return;
            }
            RegisterUser();
        }
        public void LoadDesignations()
        {
            try
            {
                AppDbContext dbContext = new();
                var designationName = from Designation in dbContext.Designations
                                     select Designation;
                materialComboBoxDesignation.DataSource = designationName.ToList();
                materialComboBoxDesignation.DisplayMember = "DesignationName";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Designations: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }
        void ResetControls()
        {
            materialTextBoxEmployeeId.Text =
                materialTextBoxFirstName.Text =
                materialTextBoxMiddleName.Text =
                materialTextBoxLastName.Text =
                materialTextBoxPassword.Text =
                materialTextBoxConfirmedPassword.Text = string.Empty;
            materialComboBoxDesignation.StartIndex = -1;
        }
    }
}
