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
        public bool _isDataValid = true;
        string parameterHint;
        public UpdateWaterParameter()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            LoadWater();
            parameterHint = WaterParameterControl.Hint;
            WaterErrorCaption.ForeColor =
                ParameterErrorControl.ForeColor = Color.Red;
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

        string _unit;
        float? _minimumControlLimit;
        string _maximumControlLimit;
        private void LoadSelectedParameterSpecification(WaterParameter waterParameter)
        {
            if (waterParameter == null)
            {
                WaterParameterControl.Hint = parameterHint;
                return;
            }
            unitControl.Hint = $"Unit - {waterParameter.Unit}";
            minimumControlLimitControl.Hint = $"{(waterParameter.MinimumControlLimit == null ? "Minimum Control Limit not set" : minimumControlLimitControl.Hint = "Minimum Control Limit - " + waterParameter.MinimumControlLimit)}";
            maximumControlLimitControl.Hint = $"Maximum Control Limit - {waterParameter.ControlLimit}";
            _unit = waterParameter.Unit;
            _minimumControlLimit = waterParameter.MinimumControlLimit;
            _maximumControlLimit = waterParameter.ControlLimit;
        }

        float newMinControlLimit;
        public void CompareControlLimitValues()
        {
            if (minimumControlLimitControl.Text.Length != 0 && maximumControlLimitControl.Text.Length != 0)
            {
                newMinControlLimit = float.Parse(minimumControlLimitControl.Text);
                if (float.Parse(maximumControlLimitControl.Text) == newMinControlLimit)
                {
                    MessageBox.Show("Minimum and Maximum Control Limit Values cannot be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
                else if (newMinControlLimit > float.Parse(maximumControlLimitControl.Text))
                {
                    MessageBox.Show("Minimum Control Limit cannot be greater than Maximum Control Limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
            }
            else if (minimumControlLimitControl.Text.Length != 0 && maximumControlLimitControl.Text.Length == 0)
            {
                newMinControlLimit = float.Parse(minimumControlLimitControl.Text);
                if (newMinControlLimit == float.Parse(_maximumControlLimit))
                {
                    MessageBox.Show("Minimum and Maximum Control Limit Values cannot be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
                else if (newMinControlLimit > float.Parse(_maximumControlLimit))
                {
                    MessageBox.Show("Minimum Control Limit cannot be greater than Maximum Control Limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
            }
            else if (maximumControlLimitControl.Text.Length != 0 && minimumControlLimitControl.Text.Length == 0)
            {
                if (float.Parse(maximumControlLimitControl.Text) == _minimumControlLimit)
                {
                    MessageBox.Show("Maximum and Minimum Control Limit Values cannot be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
                else if (_minimumControlLimit > float.Parse(maximumControlLimitControl.Text))
                {
                    MessageBox.Show("Minimum Control Limit cannot be greater than Maximum Control Limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
            }
        }

        public void ValidateUpdatedFields()
        {
            if ((maximumControlLimitControl.Text.Length == 0) && (minimumControlLimitControl.Text.Length == 0) && (unitControl.Text.Length == 0))
            {
                MessageBox.Show("Enter the parameter value to update for " + WaterParameterControl.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isDataValid = false;
                return;
            }
            else
            {
                if(maximumControlLimitControl.Text != "-")
                {
                    CompareControlLimitValues();
                }
                
            }
        }

        private void SaveParameterControl_Click(object sender, EventArgs e)
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            float newControlLimit;
            float.TryParse(maximumControlLimitControl.Text, out newControlLimit);

            ValidateFields(WaterControl.Text, WaterParameterControl.Text, newControlLimit, ref shouldSave);

            if (!shouldSave)
            {
                return;
            }
            ValidateUpdatedFields();

            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                    $"Do you want to update a parameter value for " + WaterParameterControl.Text + "?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

            if (dialogResult == DialogResult.Yes)
            {
                WaterParameter waterParameter = WaterParameterControl.SelectedItem as WaterParameter;
                Guid parameterId = waterParameter.Id;
                if ((unitControl.Text.Length != 0) && (minimumControlLimitControl.Text.Length != 0) && (maximumControlLimitControl.Text.Length != 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, unitControl.Text ,newControlLimit.ToString(), newMinControlLimit);
                }
                else if ((unitControl.Text.Length == 0) && (minimumControlLimitControl.Text.Length != 0) && (maximumControlLimitControl.Text.Length != 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, _unit, newControlLimit.ToString(), newMinControlLimit);
                }
                else if ((unitControl.Text.Length != 0) && (minimumControlLimitControl.Text.Length == 0) && (maximumControlLimitControl.Text.Length != 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, unitControl.Text, newControlLimit.ToString(), _minimumControlLimit);
                }
                else if ((unitControl.Text.Length != 0) && (minimumControlLimitControl.Text.Length != 0) && (maximumControlLimitControl.Text.Length == 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, unitControl.Text, _maximumControlLimit, newMinControlLimit);
                }
                else if ((unitControl.Text.Length != 0) && (minimumControlLimitControl.Text.Length == 0) && (maximumControlLimitControl.Text.Length == 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, unitControl.Text, _maximumControlLimit, _minimumControlLimit);
                }
                else if ((unitControl.Text.Length == 0) && (minimumControlLimitControl.Text.Length != 0) && (maximumControlLimitControl.Text.Length == 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, _unit, _maximumControlLimit, newMinControlLimit);
                }
                else if ((unitControl.Text.Length == 0) && (minimumControlLimitControl.Text.Length == 0) && (maximumControlLimitControl.Text.Length != 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, _unit, newControlLimit.ToString(), _minimumControlLimit);
                }
                else if ((unitControl.Text.Length != 0) && (minimumControlLimitControl.Text.Length != 0) && (maximumControlLimitControl.Text.Length == 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, unitControl.Text, _maximumControlLimit, newMinControlLimit);
                }
                else if ((unitControl.Text.Length != 0) && (minimumControlLimitControl.Text.Length == 0) && (maximumControlLimitControl.Text.Length != 0))
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, unitControl.Text, newControlLimit.ToString(), _minimumControlLimit);
                }
                else
                {
                    new WaterParameterService(new()).UpdateParameterControlLimit(parameterId, _unit, newControlLimit.ToString(), newMinControlLimit);
                }
                Utils.Utils.ShowMessageBox($"The control limit for {waterParameter} was updated successfully!", "Update Control Limit", MessageBoxButtons.OK);
                ResetFields();
            }
        }

        //private bool UserUpdatedControlLimit()
        //{
        //    string previousControlLimit = unitControl.Text;
        //    string newControlLimit = minimumControlLimitControl.Text;
        //    return previousControlLimit != newControlLimit;
        //}

        //private DialogResult DisplayStatus(bool userMadeChanges)
        //{
        //    if (userMadeChanges)
        //    {
        //        float newControlLimit;
        //        float previousControlLimit;
        //        float.TryParse(unitControl.Text, out previousControlLimit);
        //        float.TryParse(minimumControlLimitControl.Text, out newControlLimit);

        //        if (newControlLimit > previousControlLimit)
        //        {
        //            return Utils.Utils.ShowMessageBox($"You are choosing to update the parameter {WaterParameterControl.Text} for {WaterControl.Text} with a higher control limit. Do you wish to proceed?", "Update Control Limit", MessageBoxButtons.YesNo);
        //        }
        //        return Utils.Utils.ShowMessageBox($"Careful! You are choosing to update the parameter {WaterParameterControl.Text} for {WaterControl.Text} with a lower control limit! Do you wish to proceed?", "Update Control Limit", MessageBoxButtons.YesNo);
        //    }
        //    return Utils.Utils.ShowMessageBox("No changes were applied!", "Update Control Limit", MessageBoxButtons.OK);
        //}

        public void ValidateFields(string water, string paramater, float newControlLimit, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateSelectedWater(water, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateSelectedParameter(paramater, ref shouldSave, ref isErrorMessageDisplayed);
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

        //public void ValidateNewControlLimit(float newControlLimit, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        //{
        //    if (newControlLimit <= 0)
        //    {
        //        DisplayErrorMessage(NewControlLimitErrorControl, ref shouldSave, ref isErrorMessageDisplayed);
        //    }
        //}

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
                string.Empty;
        }

        public void ResetFields()
        {
            WaterControl.Text =
                WaterParameterControl.Text =
                unitControl.Text =
                minimumControlLimitControl.Text = 
                maximumControlLimitControl.Text = string.Empty;
            WaterControl.SelectedIndex =
                WaterParameterControl.SelectedIndex = -1;
            unitControl.Hint = "Unit";
            minimumControlLimitControl.Hint = "Minimum Control Limit";
            maximumControlLimitControl.Hint = "Maximum Control Limit";
            WaterParameterControl.Items.Clear();
        }

        private void NewSpecificationControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void maximumControlLimitControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandledForSpecifications(e.KeyChar);
        }
    }
}
