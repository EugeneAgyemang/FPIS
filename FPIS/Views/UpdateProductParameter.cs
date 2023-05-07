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

        private void LoadSelectedParameterSpecification(ProductParameter productParameter)
        {
            if(productParameter == null)
            {
                ProductParameterControl.Hint = parameterHint;
                return;
            }
            PreviousSpecificationControl.Text = $"{productParameter.Specification}";
        }

        private void SaveParameterControl_Click(object sender, EventArgs e)
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            float newSpecification;
            float.TryParse(NewSpecificationControl.Text, out newSpecification);

            ValidateFields(ProductControl.Text, ProductParameterControl.Text, newSpecification, ref shouldSave);

            if (!shouldSave)
            {
                return;
            }
            bool userMadeChanges = UserUpdatedSpecification();
            DialogResult userReponseToProceed = DisplayStatus(userMadeChanges);
            if (userReponseToProceed == DialogResult.Yes)
            {
                ProductParameter productParameter = ProductParameterControl.SelectedItem as ProductParameter;
                Guid parameterId = productParameter.Id;
                new ProductParameterService(new()).UpdateParameterSpecification(parameterId, newSpecification);
                Utils.Utils.ShowMessageBox($"The specification for {productParameter} was updated successfully!", "Update Specifiaction", MessageBoxButtons.OK);
                ResetFields();
            }
        }

        private bool UserUpdatedSpecification()
        {
            string previousSpecification = PreviousSpecificationControl.Text;
            string newSpecification = NewSpecificationControl.Text;
            return previousSpecification != newSpecification;
        }

        private DialogResult DisplayStatus(bool userMadeChanges)
        {
            if (userMadeChanges)
            {
                float newSpecification;
                float previousSpecification;
                float.TryParse(PreviousSpecificationControl.Text, out previousSpecification);
                float.TryParse(NewSpecificationControl.Text, out newSpecification);

                if (newSpecification > previousSpecification)
                {
                    return Utils.Utils.ShowMessageBox($"You are choosing to update the parameter {ProductParameterControl.Text} for {ProductControl.Text} with a higher specification. Do you wish to proceed?", "Update Specification", MessageBoxButtons.YesNo);
                }
                return Utils.Utils.ShowMessageBox($"Careful! You are choosing to update the parameter {ProductParameterControl.Text} for {ProductControl.Text} with a lower specification! Do you wish to proceed?", "Update Specification", MessageBoxButtons.YesNo);
            }
            return Utils.Utils.ShowMessageBox("No changes were applied!", "Update Specification", MessageBoxButtons.OK);
        }

        public void ValidateFields(string product, string paramater, float newSpecification, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateSelectedProduct(product, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateSelectedParameter(paramater, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateNewSpecification(newSpecification, ref shouldSave, ref isErrorMessageDisplayed);
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
                PreviousSpecificationControl.Text =
                NewSpecificationControl.Text = string.Empty;
            ProductControl.SelectedIndex =
                ProductParameterControl.SelectedIndex = -1;
            ProductParameterControl.Items.Clear();
        }

        private void NewSpecificationControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }
    }
}
