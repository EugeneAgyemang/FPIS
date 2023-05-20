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
        public bool _isDataValid = true;
        public CreateWaterParameter()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            ParameterNameErrorCaption.ForeColor =
                ParameterUnitErrorCaption.ForeColor =
                ParameterControlLimitErrorCaption.ForeColor =
                ParameterWaterErrorCaption.ForeColor = Color.Red;
            LoadWater();
        }

        float? minControlLimit;
        public void CompareControlLimitValues()
        {
            if (materialTextBoxMinimumControlLimit.Text.Length != 0)
            {
                minControlLimit = float.Parse(materialTextBoxMinimumControlLimit.Text);
                if (float.Parse(ParameterControlLimitControl.Text) == minControlLimit)
                {
                    MessageBox.Show("Minimum and Maximum Control Limit Values cannot be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
                else if (minControlLimit > float.Parse(ParameterControlLimitControl.Text))
                {
                    MessageBox.Show("Minimum Control limit cannot be greater than Maximum Control limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
            }
            else
            {
                minControlLimit = null;
            }
        }

        private void SaveParameterControl_Click(object sender, EventArgs e)
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            float parameterControlLimit;
            float.TryParse(ParameterControlLimitControl.Text, out parameterControlLimit);

            ValidateFields(ParameterNameControl.Text, ParameterUnitControl.Text, parameterControlLimit, ParameterWaterControl.Text, ref shouldSave);

            if (!shouldSave)
            {
                return;
            }
            CompareControlLimitValues();
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox("Do you wish to proceed?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userReponseToProceed != DialogResult.Yes)
            {
                return;
            }
            AppDbContext appDbContext = new();
            WaterParameterService waterParameterService = new WaterParameterService(appDbContext);
            Water water = new WaterService(new()).GetWaterByName(ParameterWaterControl.Text);
            bool isWaterParameterAlreadySaved = waterParameterService.DoesWaterParameterExist(ParameterNameControl.Text, water.Id);
            if (isWaterParameterAlreadySaved)
            {
                Utils.Utils.ShowMessageBox("The water parameter you provided already exists", "Duplicate Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WaterParameter productParameter = waterParameterService.Save
                (ParameterNameControl.Text,
                ParameterUnitControl.Text,
                parameterControlLimit,
                water.Id,
                minControlLimit);
            if (productParameter != null)
            {
                ResetFields();
                Utils.Utils.ShowMessageBox("Water parameter saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ValidateFields(string parameterName, string parameterUnit, float parameterControlLimit, string parameterWater, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateParameterName(parameterName, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateParameterUnit(parameterUnit, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateParameterControlLimit(parameterControlLimit, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateParameterWater(parameterWater, ref shouldSave, ref isErrorMessageDisplayed);
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
        public void ValidateParameterWater(string parameterWater, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterWater.Length == 0)
            {
                DisplayErrorMessage(ParameterWaterErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
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
                ParameterWaterErrorCaption.Text =
                ParameterControlLimitErrorCaption.Text = string.Empty;
        }
        public void ResetFields()
        {
            ParameterNameControl.Text =
                ParameterUnitControl.Text =
                ParameterControlLimitControl.Text =
                materialTextBoxMinimumControlLimit.Text =
                string.Empty;
            ParameterWaterControl.StartIndex = -1;
        }

        private void ParameterControlLimitControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }
        public void LoadWater()
        {
            List<Water> water = new WaterService(new()).GetAllWater();
            ParameterWaterControl.Items.AddRange(water.ToArray());
        }

        private void materialTextBoxMinimumControlLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }
    }
}
