﻿using FPIS.Models;
using FPIS.Services;
using FPIS.Utils;
using FPIS.Views;
using MaterialSkin.Controls;
using System;
using System.Text;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS
{
    public partial class Login : MaterialForm
    {
        public Role userRole;
        public Login()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            EmployeeIdErrorControl.ForeColor =
                PasswordErrorControl.ForeColor = Color.Red;
        }
        public void ResetFields()
        {
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ResetErrorCaptions();
            bool shouldSave = true;

            string employeeId = txtEmpId.Text.Trim();
            string password = txtPassword.Text.Trim();

            ValidateFields(employeeId,
                password,
                ref shouldSave);

            if (!shouldSave)
            {
                return;
            }


            AppDbContext appDbContext = new();
            try
            {
                LoginService loginService = new(appDbContext);
                LoginAuth loginResults = loginService.AuthenticateUser(employeeId, password);
                if (loginResults == LoginAuth.AUTH_FAIL)
                {
                    Utils.Utils.ShowMessageBox("Invalid login credentials", "Login Failed");
                    ResetFields();
                }
                else
                {
                    userRole = new Role();
                    Department department = new UserService(new())
                                                .GetUserDepartmentDetailsByEmpId
                                                    (txtEmpId
                                                    .Text
                                                    .Trim()
                                                    )
                                                    .Designation
                                                    .Department;
                    userRole.TagFinder(department);
                    txtPassword.Text = string.Empty;
                    Main.LOGGED_USER_ID = new UserService(new()).GetEmployeeId(employeeId).ToString();
                    Hide();
                    Main main = new Main(this);
                    main.Show();
                }
            }
            catch (Exception exception)
            {
                Utils.Utils.ShowMessageBox(exception.Message, "Oops... An error occured");
            }
            finally
            {
                appDbContext.Dispose();
            }
        }
        public void ValidateFields(string empId, string password, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateEmpId(empId, ref shouldSave, ref isErrorMessageDisplayed);
            ValidatePassword(password, ref shouldSave, ref isErrorMessageDisplayed);

        }
        public void ValidateEmpId(string empId, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (empId.Length == 0)
            {
                DisplayErrorMessage(EmployeeIdErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need your Employee ID");
                return;
            }
        }
        public void ValidatePassword(string password, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (password.Length == 0)
            {
                DisplayErrorMessage(PasswordErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need your password");
                return;
            }
        }
        private void DisplayErrorMessage(Label errorCaption, ref bool shouldSave, ref bool isErrorMessageDisplayed, string message)
        {
            shouldSave = false;
            if (!isErrorMessageDisplayed)
            {
                isErrorMessageDisplayed = true;
                Utils.Utils.ShowMessageBox("An error occuured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            errorCaption.Text = message;
        }
        public void ResetErrorCaptions()
        {
            EmployeeIdErrorControl.Text =
                PasswordErrorControl.Text = string.Empty;
        }

        private void CreateAccountControl_Click(object sender, EventArgs e)
        {
            Hide();
            new Register(this).Show();
        }
        public class Role
        {
            public StringBuilder tags = new StringBuilder();
            public void TagFinder(Department department)
            {
                tags.Append("0 ");
                string departmentName = department.DepartmentName.ToLower();
                switch(departmentName)
                {
                    case "production":
                        tags.Append("1 ");
                        break;
                    case "quality control":
                        tags.Append("2 ");
                        tags.Append("3 ");
                        tags.Append("4 ");
                        tags.Append("6 ");
                        break;
                    case "procurement":
                        tags.Append("6 ");
                        break;
                }
                tags.Append("5 ");
                tags.Append("7");
            }
        }
    }
}
