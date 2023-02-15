using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class CreateWaterParameter : MaterialForm
    {
        public CreateWaterParameter()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            ParameterNameErrorCaption.ForeColor =
                ParameterUnitErrorCaption.ForeColor =
                ParameterControlLimitErrorCaption.ForeColor = Color.Red;
        }

        private void SaveParameterControl_Click(object sender, EventArgs e)
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            float parameterControlLimit;
            float.TryParse(ParameterControlLimitControl.Text, out parameterControlLimit);

            ValidateFields(ParameterNameControl.Text, ParameterUnitControl.Text, parameterControlLimit, ref shouldSave);

            if (!shouldSave)
            {
                return;
            }
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox("Do you wish to proceed?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userReponseToProceed != DialogResult.Yes)
            {
                return;
            }
            AppDbContext appDbContext = new();
            WaterParameterService waterParameterService = new WaterParameterService(appDbContext);
            bool isWaterParameterAlreadySaved = waterParameterService.DoesWaterParameterExist(ParameterNameControl.Text);
            if (isWaterParameterAlreadySaved)
            {
                Utils.Utils.ShowMessageBox("The water parameter you provided already exists", "Duplicate Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WaterParameter productParameter = waterParameterService.Save
                (ParameterNameControl.Text,
                ParameterUnitControl.Text,
                parameterControlLimit);
            if (productParameter != null)
            {
                ResetFields();
                Utils.Utils.ShowMessageBox("Water parameter saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ValidateFields(string parameterName, string parameterUnit, float parameterControlLimit, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateParameterName(parameterName, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateParameterUnit(parameterUnit, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateParameterControlLimit(parameterControlLimit, ref shouldSave, ref isErrorMessageDisplayed);
        }
        public void ValidateParameterName(string parameterName, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterName.Length == 0)
            {
                DisplayErrorMessage(ParameterNameErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }
        public void ValidateParameterUnit(string parameterUnit, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterUnit.Length == 0)
            {
                DisplayErrorMessage(ParameterUnitErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }
        public void ValidateParameterControlLimit(float parameterControlLimit, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterControlLimit <= 0)
            {
                DisplayErrorMessage(ParameterControlLimitErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }
        private void DisplayErrorMessage(Label errorCaption, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            shouldSave = false;
            if (!isErrorMessageDisplayed)
            {
                isErrorMessageDisplayed = true;
                Utils.Utils.ShowMessageBox("An error occuured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            errorCaption.Text = "An invalid value was entered!";
        }

        public void ResetErrorCaptions()
        {
            ParameterNameErrorCaption.Text =
                ParameterUnitErrorCaption.Text =
                ParameterControlLimitErrorCaption.Text = string.Empty;
        }
        public void ResetFields()
        {
            ParameterNameControl.Text =
                ParameterUnitControl.Text =
                ParameterControlLimitControl.Text =
                string.Empty;
        }

        private void ParameterControlLimitControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }
    }
}
