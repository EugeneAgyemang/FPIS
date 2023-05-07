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
    public partial class UpdateWaterParameter : MaterialForm
    {
        string parameterHint;
        public UpdateWaterParameter()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            LoadWater();
            parameterHint = WaterParameterControl.Hint;
            WaterErrorCaption.ForeColor =
                ParameterErrorControl.ForeColor =
                NewControlLimitErrorControl.ForeColor = Color.Red;
        }

        private void LoadWater()
        {
            List<Water> water = new WaterService(new()).GetAllWater();
            WaterControl.Items.AddRange(water.ToArray());
            WaterControl.SelectedIndex = -1;
        }

        private void LoadSelectedWaterParameters()
        {
            Water selectedWater = WaterControl.SelectedItem as Water;
            if (selectedWater == null)
            {
                return;
            }
            Guid waterId = selectedWater.Id;
            List<WaterParameter> parameters = new WaterParameterService(new()).GetWaterParameters(waterId);
            WaterParameterControl.Items.Clear();
            WaterParameterControl.Items.AddRange(parameters.ToArray());
            UpdateParameterHint(parameters.Count);
        }

        private void UpdateParameterHint(int totalParameters)
        {
            WaterParameterControl.Hint = $"{(totalParameters == 0 ? "No parameters available" : (totalParameters == 1) ? totalParameters + " " + parameterHint.ToLower() + " found" : totalParameters + " " + parameterHint.ToLower() + "s found")}";
        }

        private void WaterControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedWaterParameters();
        }

        private void WaterParameterControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            WaterParameter selectedParameter = WaterParameterControl.SelectedItem as WaterParameter;
            LoadSelectedParameterSpecification(selectedParameter);
        }

        private void LoadSelectedParameterSpecification(WaterParameter waterParameter)
        {
            if (waterParameter == null)
            {
                WaterParameterControl.Hint = parameterHint;
                return;
            }
            PreviousControlLimitControl.Text = $"{waterParameter.ControlLimit}";
        }

        private void SaveParameterControl_Click(object sender, EventArgs e)
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            float newControlLimit;
            float.TryParse(NewControlLimitControl.Text, out newControlLimit);

            ValidateFields(WaterControl.Text, WaterParameterControl.Text, newControlLimit, ref shouldSave);

            if (!shouldSave)
            {
                return;
            }
            bool userMadeChanges = UserUpdatedControlLimit();
            DialogResult userReponseToProceed = DisplayStatus(userMadeChanges);
            if (userReponseToProceed == DialogResult.Yes)
            {
                WaterParameter waterParameter = WaterParameterControl.SelectedItem as WaterParameter;
                Guid parameterId = waterParameter.Id;
                new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, newControlLimit);
                Utils.Utils.ShowMessageBox($"The control limit for {waterParameter} was updated successfully!", "Update Control Limit", MessageBoxButtons.OK);
                ResetFields();
            }
        }

        private bool UserUpdatedControlLimit()
        {
            string previousControlLimit = PreviousControlLimitControl.Text;
            string newControlLimit = NewControlLimitControl.Text;
            return previousControlLimit != newControlLimit;
        }

        private DialogResult DisplayStatus(bool userMadeChanges)
        {
            if (userMadeChanges)
            {
                float newControlLimit;
                float previousControlLimit;
                float.TryParse(PreviousControlLimitControl.Text, out previousControlLimit);
                float.TryParse(NewControlLimitControl.Text, out newControlLimit);

                if (newControlLimit > previousControlLimit)
                {
                    return Utils.Utils.ShowMessageBox($"You are choosing to update the parameter {WaterParameterControl.Text} for {WaterControl.Text} with a higher control limit. Do you wish to proceed?", "Update Control Limit", MessageBoxButtons.YesNo);
                }
                return Utils.Utils.ShowMessageBox($"Careful! You are choosing to update the parameter {WaterParameterControl.Text} for {WaterControl.Text} with a lower control limit! Do you wish to proceed?", "Update Control Limit", MessageBoxButtons.YesNo);
            }
            return Utils.Utils.ShowMessageBox("No changes were applied!", "Update Control Limit", MessageBoxButtons.OK);
        }

        public void ValidateFields(string water, string paramater, float newControlLimit, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateSelectedWater(water, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateSelectedParameter(paramater, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateNewControlLimit(newControlLimit, ref shouldSave, ref isErrorMessageDisplayed);
        }

        public void ValidateSelectedWater(string water, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (water.Length == 0)
            {
                DisplayErrorMessage(WaterErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }

        public void ValidateSelectedParameter(string parameterName, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterName.Length == 0)
            {
                DisplayErrorMessage(ParameterErrorControl, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }

        public void ValidateNewControlLimit(float newControlLimit, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (newControlLimit < 1)
            {
                DisplayErrorMessage(NewControlLimitErrorControl, ref shouldSave, ref isErrorMessageDisplayed);
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
            ParameterErrorControl.Text =
                WaterErrorCaption.Text =
                NewControlLimitErrorControl.Text =
                string.Empty;
        }

        public void ResetFields()
        {
            WaterControl.Text =
                WaterParameterControl.Text =
                PreviousControlLimitControl.Text =
                NewControlLimitControl.Text = string.Empty;
            WaterControl.SelectedIndex =
                WaterParameterControl.SelectedIndex = -1;
            WaterParameterControl.Items.Clear();
        }

        private void NewSpecificationControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }
    }
}
