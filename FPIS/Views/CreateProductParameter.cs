using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class CreateProductParameter : MaterialForm
    {
        public CreateProductParameter()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            ParameterNameErrorCaption.ForeColor = 
                ParameterMethodErrorCaption.ForeColor = 
                ParameterUnitErrorCaption.ForeColor = 
                ParameterSpecificationErrorCaption.ForeColor = Color.Red;
        }

        private void SaveParameterControl_Click(object sender, EventArgs e)
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            float parameterSpecification;
            float.TryParse(ParameterSpecificationControl.Text, out parameterSpecification);

            ValidateFields(ParameterNameControl.Text, ParameterMethodControl.Text, ParameterUnitControl.Text, parameterSpecification, ref shouldSave);

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
            ProductParameterService productParameterService = new ProductParameterService(appDbContext);
            bool isProductParameterAlreadySaved = productParameterService.DoesProductParameterExist(ParameterNameControl.Text);
            if (isProductParameterAlreadySaved)
            {
                Utils.Utils.ShowMessageBox("The product parameter you provided already exists", "Duplicate Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProductParameter productParameter = productParameterService.Save
                (ParameterNameControl.Text,
                ParameterUnitControl.Text,
                ParameterMethodControl.Text,
                parameterSpecification);
            if (productParameter != null)
            {
                ResetFields();
                Utils.Utils.ShowMessageBox("Product parameter saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ValidateFields(string parameterName, string parameterMethod, string parameterUnit, float parameterSpecification, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateParameterName(parameterName, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateParameterMethod(parameterMethod, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateParameterUnit(parameterUnit, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateParameterSpecification(parameterSpecification, ref shouldSave, ref isErrorMessageDisplayed);
        }
        public void ValidateParameterName(string parameterName, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterName.Length == 0)
            {
                DisplayErrorMessage(ParameterNameErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }
        public void ValidateParameterMethod(string parameterMehtod, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterMehtod.Length == 0)
            {
                DisplayErrorMessage(ParameterMethodErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }
        public void ValidateParameterUnit(string parameterUnit, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterUnit.Length == 0)
            {
                DisplayErrorMessage(ParameterUnitErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }
        public void ValidateParameterSpecification(float parameterSpecification, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (parameterSpecification <= 0)
            {
                DisplayErrorMessage(ParameterSpecificationErrorCaption, ref shouldSave, ref isErrorMessageDisplayed);
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
                ParameterMethodErrorCaption.Text =
                ParameterSpecificationErrorCaption.Text =
                ParameterUnitErrorCaption.Text = string.Empty;
        }
        public void ResetFields()
        {
            ParameterNameControl.Text = 
                ParameterMethodControl.Text = 
                ParameterUnitControl.Text = 
                ParameterSpecificationControl.Text = 
                string.Empty;
        }

        private void ParameterSpecificationControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }
    }
}
