using FPIS.Models;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class AddDepartment : MaterialForm
    {
        bool _isDataValid = true;
        string departmentName;
        public AddDepartment()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            labelDepartmentName.Text = "";
        }
        private void ClearErrorLabels()
        {
            labelDepartmentName.Text = "";
            
        }
        private void ValidateDepartmentName()
        {

            // 3 characters or more, no numbers and special characters
            string nameRegexPattern = "^[ a-zA-Z]{3,}$";

            departmentName = materialTextBoxDepartmentName.Text.Trim();

            if (departmentName.Length == 0)
            {
                labelDepartmentName.ForeColor = System.Drawing.Color.Red;
                labelDepartmentName.Text = "Department name is required!";
                _isDataValid = false;
                return;
            }
            CheckIfDepartmentExist(departmentName);
            Regex regex = new(nameRegexPattern);

            if (!regex.IsMatch(departmentName))
            {
                labelDepartmentName.ForeColor = System.Drawing.Color.Red;
                labelDepartmentName.Text = "Department name cannot have numbers.";
                _isDataValid = false;
                return;
            }
        }
        private void CheckIfDepartmentExist(string departmentName)
        {
            AppDbContext dbContext = new();
            var department = dbContext.Departments.FirstOrDefault(department => department.DepartmentName == departmentName);
            dbContext.Dispose();

            if (department != null)
            {
                _isDataValid = false;
                labelDepartmentName.ForeColor = System.Drawing.Color.Red;
                labelDepartmentName.Text = "Department already Created.";
                return;
            }
        }
        private void ValidateInputs()
        {
            ValidateDepartmentName();
         
        }

        private void CreateDepartment()
        {
            btnAddDepartment.Enabled = false;

            Department department = new()
            {
                DepartmentName = materialTextBoxDepartmentName.Text, 
            };
            AppDbContext dbContext = new();
            try
            {
                
                dbContext.Departments.Add(department);
                dbContext.SaveChanges();

                MessageBox.Show(
                    $"\"{department.DepartmentName}\" Department created successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating Department: {ex}");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                btnAddDepartment.Enabled = true;
                materialTextBoxDepartmentName.Text = "";
                dbContext.Dispose();
            }
        }

        private void ConfirmNewDepartment()
        {
            DialogResult dialogResult = MaterialMessageBox.Show(
                $"Do you want to create \"{departmentName}\" as a new Department?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                CreateDepartment();
            }
            else if (dialogResult == DialogResult.No)
            {
                materialTextBoxDepartmentName.Text = "";
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
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
            ConfirmNewDepartment();
        }
    }
}
