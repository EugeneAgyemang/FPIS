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
    public partial class AddDesignation : MaterialForm
    {

        bool _isDataValid = true;
        string designationName;
        public AddDesignation()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            ClearErrorLabels();
        }
        private void ClearErrorLabels()
        {
            labelDepartmentName.Text = "";
            labelDesignation.Text = "";
        }
        private void ValidateDesignationName()
        {
            // 3 characters or more, no numbers and special characters
            string nameRegexPattern = "^[ a-zA-Z]{3,}$";

            designationName = materialTextBoxDesignationName.Text.Trim();

            if (designationName.Length == 0)
            {
                labelDesignation.ForeColor = System.Drawing.Color.Red;
                labelDesignation.Text = "Designation name is required!";
                _isDataValid = false;
                return;
            }
            CheckIfDesignationExist(designationName);
            Regex regex = new(nameRegexPattern);

            if (!regex.IsMatch(designationName))
            {
                labelDesignation.ForeColor = System.Drawing.Color.Red;
                labelDesignation.Text = "Designation name cannot have numbers.";
                _isDataValid = false;
                return;
            }
        }
        private void CheckIfDesignationExist(string designationName)
        {
            AppDbContext dbContext = new();
            var designation = dbContext.Designations.FirstOrDefault(designation => designation.DesignationName == designationName);
            dbContext.Dispose();

            if (designation != null)
            {
                _isDataValid = false;
                labelDesignation.ForeColor = System.Drawing.Color.Red;
                labelDesignation.Text = "Designation already Created.";
                return;
            }
        }
        private void ValidateInputs()
        {
            ValidateDesignationName();
            ValidateDepartment();
        }
        private void LoadDeparments()
        {
            try
            {
                AppDbContext dbContext = new();
                var departmentName = from Department in dbContext.Departments
                                     select Department;
                materialComboBoxDepartmentName.DataSource = departmentName.ToList();
                materialComboBoxDepartmentName.DisplayMember = "DepartmentName";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Departments: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void AddDesignation_Load(object sender, EventArgs e)
        {
           LoadDeparments();
        }   
        private void CreateDesignation()
        {
            btnAddDesignation.Enabled = false;
            AppDbContext dbContext = new();
            var department = dbContext.Departments.Where(dpt => dpt.DepartmentName == materialComboBoxDepartmentName.Text).Single();
            
            Designation designation = new()
            {
                
                DesignationName = materialTextBoxDesignationName.Text,
                DepartmentId = department.Id,

            };
            try
            {
                dbContext.Designations.Add(designation);
                dbContext.SaveChanges();

                MessageBox.Show(
                    $"\"{designation.DesignationName}\" Designation created successfully under {materialComboBoxDepartmentName.Text} Department.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Console.WriteLine($"Create designation {designation}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating Department: {ex}");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                btnAddDesignation.Enabled = true;
                materialTextBoxDesignationName.Text = "";
                materialComboBoxDepartmentName.StartIndex = -1;
                dbContext.Dispose();
            }
        }

        private void ConfirmNewDesignation()
        {
            DialogResult dialogResult = Utils.Utils.ShowMessageBox(
                $"Do you want to create \"{designationName}\" as a new Designation?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                CreateDesignation();
            }
        }

        private void btnAddDesignation_Click(object sender, EventArgs e)
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
            ConfirmNewDesignation();
        }
      
        private void ValidateDepartment()
        {
            _isDataValid = true;
            string departmentName = materialComboBoxDepartmentName.Text.Trim();
            if (departmentName.Length == 0)
            {
                _isDataValid = false;
            }
        }
    }
}
