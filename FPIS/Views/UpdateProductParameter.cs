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
    public partial class UpdateProductParameter : MaterialForm
    {
        public bool _isDataValid = true;
        string parameterHint;
        public UpdateProductParameter()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            LoadProducts();
            parameterHint = ProductParameterControl.Hint;
            ProductErrorCaption.ForeColor =
                ParameterErrorControl.ForeColor =
                NewSpecificationErrorControl.ForeColor = Color.Red;
        }

        private void LoadProducts()
        {
            List<Product> products = new ProductService(new()).GetAllProducts();
            ProductControl.Items.AddRange(products.ToArray());
            ProductControl.SelectedIndex = -1;
        }

        private void LoadSelectedProductParameters()
        {
            Product selectedProduct = ProductControl.SelectedItem as Product;
            if (selectedProduct == null)
            {
                return;
            }
            Guid productId = selectedProduct.Id;
            List<ProductParameter> parameters = new ProductParameterService(new()).GetProductParameters(productId);
            ProductParameterControl.Items.Clear();
            ProductParameterControl.Items.AddRange(parameters.ToArray());
            UpdateParameterHint(parameters.Count);
        }

        private void UpdateParameterHint(int totalParameters)
        {
            ProductParameterControl.Hint = $"{(totalParameters == 0 ? "No parameters available" : (totalParameters == 1) ? totalParameters + " " + parameterHint.ToLower() + " found" : totalParameters + " " + parameterHint.ToLower() + "s found")}";
        }

        private void ProductControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedProductParameters();
        }

        private void ProductParameterControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductParameter selectedParameter = ProductParameterControl.SelectedItem as ProductParameter;
            LoadSelectedParameterSpecification(selectedParameter);
        }

        string _method, _unit;
        float? _minimumSpecification;
        float _maximumSpecification;
        private void LoadSelectedParameterSpecification(ProductParameter productParameter)
        {
            if(productParameter == null)
            {
                ProductParameterControl.Hint = parameterHint;
                return;
            }
            methodControl.Hint = $"Method - {productParameter.Method}";
            unitControl.Hint = $"Unit - {productParameter.Unit}";
            minimumSpecificationControl.Hint = $"{(productParameter.MinimumSpecification == null ? "Minimum Specification not set": minimumSpecificationControl.Hint= "Minimum Specification - "+productParameter.MinimumSpecification)}";
            maximumSpecificationControl.Hint = $"Maximum Specification - {productParameter.Specification}";
            _method = productParameter.Method;
            _unit = productParameter.Unit;
            _minimumSpecification= productParameter.MinimumSpecification;
            _maximumSpecification = float.Parse(productParameter.Specification);
        }

        float newMinSpecification;
        public void CompareSpecificationValues()
        {
            if (minimumSpecificationControl.Text.Length != 0 && maximumSpecificationControl.Text.Length != 0)
            {
                newMinSpecification = float.Parse(minimumSpecificationControl.Text);
                if (float.Parse(maximumSpecificationControl.Text) == newMinSpecification)
                {
                    MessageBox.Show("Minimum and Maximum Spaecification Values cannot be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
                else if (newMinSpecification > float.Parse(maximumSpecificationControl.Text))
                {
                    MessageBox.Show("Minimum Spaecification cannot be greater than Maximum Specification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
            }
            else if(minimumSpecificationControl.Text.Length != 0 && maximumSpecificationControl.Text.Length == 0)
            {
                newMinSpecification = float.Parse(minimumSpecificationControl.Text);
                if (newMinSpecification == _maximumSpecification)
                {
                    MessageBox.Show("Minimum and Maximum Spaecification Values cannot be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
                else if (newMinSpecification > _maximumSpecification)
                {
                    MessageBox.Show("Minimum Spaecification cannot be greater than Maximum Specification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
            }
            else if (maximumSpecificationControl.Text.Length != 0 && minimumSpecificationControl.Text.Length == 0)
            {
                if (float.Parse(maximumSpecificationControl.Text) == _minimumSpecification)
                {
                    MessageBox.Show("Maximum and Minimum Spaecification Values cannot be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
                else if (_minimumSpecification > float.Parse(maximumSpecificationControl.Text))
                {
                    MessageBox.Show("Minimum Spaecification cannot be greater than Maximum Specification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isDataValid = false;
                    return;
                }
            }
        }

        public void ValidateUpdatedFields()
        {
            if ((maximumSpecificationControl.Text.Length == 0) && (minimumSpecificationControl.Text.Length == 0) && (methodControl.Text.Length == 0) && (unitControl.Text.Length == 0))
            {
                MessageBox.Show("Enter the parameter value to update for " + ProductParameterControl.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isDataValid = false;
                return;
            }
            else
            {
                if (maximumSpecificationControl.Text != "-")
                {
                    CompareSpecificationValues();
                }
                
            }
        }

        private void SaveParameterControl_Click(object sender, EventArgs e)
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            float newSpecification;
            float.TryParse(maximumSpecificationControl.Text, out newSpecification);

            ValidateFields(ProductControl.Text, ProductParameterControl.Text, newSpecification, ref shouldSave);

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
                    $"Do you want to update a parameter value for "+ProductParameterControl.Text+"?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

            if (dialogResult == DialogResult.Yes)
            {
                ProductParameter productParameter = ProductParameterControl.SelectedItem as ProductParameter;
                Guid parameterId = productParameter.Id;
                if((methodControl.Text.Length != 0) && (unitControl.Text.Length != 0) && (minimumSpecificationControl.Text.Length != 0) && (maximumSpecificationControl.Text.Length != 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId,unitControl.Text, methodControl.Text ,newSpecification.ToString(), newMinSpecification);
                }
                else if ((methodControl.Text.Length == 0) && (unitControl.Text.Length != 0) && (minimumSpecificationControl.Text.Length != 0) && (maximumSpecificationControl.Text.Length != 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, unitControl.Text, _method, newSpecification.ToString(), newMinSpecification);
                }
                else if ((methodControl.Text.Length != 0) && (unitControl.Text.Length == 0) && (minimumSpecificationControl.Text.Length != 0) && (maximumSpecificationControl.Text.Length != 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, _unit, methodControl.Text, newSpecification.ToString(), newMinSpecification);
                }
                else if ((methodControl.Text.Length != 0) && (unitControl.Text.Length != 0) && (minimumSpecificationControl.Text.Length == 0) && (maximumSpecificationControl.Text.Length != 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, unitControl.Text, methodControl.Text, newSpecification.ToString(), _minimumSpecification);
                }
                else if ((methodControl.Text.Length != 0) && (unitControl.Text.Length != 0) && (minimumSpecificationControl.Text.Length != 0) && (maximumSpecificationControl.Text.Length == 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, unitControl.Text, methodControl.Text, _maximumSpecification.ToString(), newMinSpecification);
                }
                else if ((methodControl.Text.Length != 0) && (unitControl.Text.Length == 0) && (minimumSpecificationControl.Text.Length == 0) && (maximumSpecificationControl.Text.Length == 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, _unit, methodControl.Text, _maximumSpecification.ToString(), _minimumSpecification);
                }
                else if ((methodControl.Text.Length == 0) && (unitControl.Text.Length != 0) && (minimumSpecificationControl.Text.Length == 0) && (maximumSpecificationControl.Text.Length == 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, unitControl.Text, _unit, _maximumSpecification.ToString(), _minimumSpecification);
                }
                else if ((methodControl.Text.Length == 0) && (unitControl.Text.Length == 0) && (minimumSpecificationControl.Text.Length != 0) && (maximumSpecificationControl.Text.Length == 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, _unit, _method, _maximumSpecification.ToString(), newMinSpecification);
                }
                else if ((methodControl.Text.Length == 0) && (unitControl.Text.Length == 0) && (minimumSpecificationControl.Text.Length == 0) && (maximumSpecificationControl.Text.Length != 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, _unit, _method, newSpecification.ToString(), _minimumSpecification);
                }
                else if ((methodControl.Text.Length != 0) && (unitControl.Text.Length != 0) && (minimumSpecificationControl.Text.Length == 0) && (maximumSpecificationControl.Text.Length == 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, unitControl.Text, methodControl.Text, _maximumSpecification.ToString(), _minimumSpecification);
                }
                else if ((methodControl.Text.Length != 0) && (unitControl.Text.Length == 0) && (minimumSpecificationControl.Text.Length != 0) && (maximumSpecificationControl.Text.Length == 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, _unit, methodControl.Text, _maximumSpecification.ToString(), newMinSpecification);
                }
                else if ((methodControl.Text.Length != 0) && (unitControl.Text.Length == 0) && (minimumSpecificationControl.Text.Length == 0) && (maximumSpecificationControl.Text.Length != 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, _unit, methodControl.Text, newSpecification.ToString(), _minimumSpecification);
                }
                else if ((methodControl.Text.Length == 0) && (unitControl.Text.Length != 0) && (minimumSpecificationControl.Text.Length != 0) && (maximumSpecificationControl.Text.Length == 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, unitControl.Text, _method, _maximumSpecification.ToString(), newMinSpecification);
                }
                else if ((methodControl.Text.Length == 0) && (unitControl.Text.Length != 0) && (minimumSpecificationControl.Text.Length == 0) && (maximumSpecificationControl.Text.Length != 0))
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, unitControl.Text, _method, newSpecification.ToString(), _minimumSpecification);
                }
                else
                {
                    new ProductParameterService(new()).UpdateParameterSpecification(parameterId, _unit, _method, newSpecification.ToString(), newMinSpecification);
                }

                Utils.Utils.ShowMessageBox($"The Parameter values for {productParameter} was updated successfully!", "Update Successful", MessageBoxButtons.OK);
                ResetFields();
            }
        }

        //private bool UserUpdatedSpecification()
        //{
        //    string previousSpecification = minimumSpecificationControl.Text;
        //    string newSpecification = maximumSpecificationControl.Text;
        //    return previousSpecification != newSpecification;
        //}

        //private DialogResult DisplayStatus(bool userMadeChanges)
        //{
        //    if (userMadeChanges)
        //    {
        //        float newSpecification, newMinSpecification;
        //        float previousSpecification, previousMinSpecification;
        //        float.TryParse(minimumSpecificationControl.Text, out previousSpecification);
        //        float.TryParse(maximumSpecificationControl.Text, out newSpecification);
        //        float.TryParse(methodControl.Text, out previousMinSpecification);
        //        float.TryParse(unitControl.Text, out newMinSpecification);

        //        if (newSpecification > previousSpecification)
        //        {
        //            return Utils.Utils.ShowMessageBox($"You are choosing to update the parameter {ProductParameterControl.Text} for {ProductControl.Text} with a higher specification. Do you wish to proceed?", "Update Specification", MessageBoxButtons.YesNo);
        //        }
        //        return Utils.Utils.ShowMessageBox($"Careful! You are choosing to update the parameter {ProductParameterControl.Text} for {ProductControl.Text} with a lower specification! Do you wish to proceed?", "Update Specification", MessageBoxButtons.YesNo);
        //    }
        //    return Utils.Utils.ShowMessageBox("No changes were applied!", "Update Specification", MessageBoxButtons.OK);
        //}

        public void ValidateFields(string product, string paramater, float newSpecification, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateSelectedProduct(product, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateSelectedParameter(paramater, ref shouldSave, ref isErrorMessageDisplayed);
           // ValidateNewSpecification(newSpecification, ref shouldSave, ref isErrorMessageDisplayed);
        }

        public void ValidateSelectedProduct(string product, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (product.Length == 0)
            {
                DisplayErrorMessage(ProductErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }

        public void ValidateSelectedParameter(string parameterName, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterName.Length == 0)
            {
                DisplayErrorMessage(ParameterErrorControl, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }

        public void ValidateNewSpecification(float newSpecification, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (newSpecification <= 0)
            {
                DisplayErrorMessage(NewSpecificationErrorControl, ref shouldSave, ref isErrorMessageDisplayed);
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
                ProductErrorCaption.Text =
                NewSpecificationErrorControl.Text =
                string.Empty;
        }

        public void ResetFields()
        {
            ProductControl.Text =
                ProductParameterControl.Text =
                minimumSpecificationControl.Text =
                unitControl.Text =
                methodControl.Text =
                maximumSpecificationControl.Text = string.Empty;
            ProductControl.SelectedIndex =
                ProductParameterControl.SelectedIndex = -1;
            methodControl.Hint = "Method";
            unitControl.Hint = "Unit";
            minimumSpecificationControl.Hint = "Minimum Specification";
            maximumSpecificationControl.Hint = "Maximum Specification";
            ProductParameterControl.Items.Clear();
        }

        private void minimumSpecificationControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void NewSpecificationControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandledForSpecifications(e.KeyChar);
        }
    }
}
