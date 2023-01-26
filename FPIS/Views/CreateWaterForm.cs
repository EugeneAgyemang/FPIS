using FPIS.Models;
using FPIS.Services;
using FPIS.Utils;
using MaterialSkin.Controls;
using System.Diagnostics.Metrics;

namespace FPIS.Views
{
    public partial class CreateWaterForm : MaterialForm
    {
        private bool _isDataValid = true;

        public CreateWaterForm()
        {
            InitializeComponent();
            materialLabelWaterNameError.ForeColor = System.Drawing.Color.Red;
        }
        public void ClearFormFields()
        {
            materialTextBoxWaterName.Text = "";
        }

        public void ClearErrorLabels()
        {
            materialLabelWaterNameError.Text = "";
        }

        public void ValidateWaterName()
        {
            string waterName = materialTextBoxWaterName.Text.Trim();

            if (waterName.Length == 0)
            {
                this._isDataValid = false;
                materialLabelWaterNameError.Text = "Water name is required!";
            }
        }

        public void ValidateInputs()
        {
            ValidateWaterName();
        }

        private void materialButtonCreateWater_Click(object sender, EventArgs e)
        {
            string waterName = materialTextBoxWaterName.Text.Trim();
            _isDataValid = true; // reset this, else the windows will need restart to reset it.

            ClearErrorLabels();
            ValidateInputs(); // validate all form inputs

            if (!_isDataValid)
            {
                return;
            }

            DialogResult confirmDialogResult = Utils.Utils.ShowMessageBox(
                $"Do you want to create \"{waterName}\" as a new water?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (confirmDialogResult != DialogResult.Yes)
            {
                return;
            }

            materialButtonCreateWater.Enabled = false;

            AppDbContext? dbContext = null;

            try
            {
                dbContext = new();

                WaterService waterService = new(dbContext);

                if (waterService.DoesWaterExists(waterName))
                {

                    Utils.Utils.ShowMessageBox(
                        $"\"{waterName}\" already exists, please change it.",
                        "Water Already Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );

                    materialButtonCreateWater.Enabled = true;
                    return;
                }

                waterService.CreateWater(waterName);

                Utils.Utils.ShowMessageBox(
                    message: $"Water \"{waterName}\" is created!",
                    title: "Water Created Successfully"
                    );

                materialButtonCreateWater.Enabled = true;
                ClearFormFields();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to create water. Details: {ex}");
                materialButtonCreateWater.Enabled = true;

                Utils.Utils.ShowMessageBox(
                    message: $"\"{waterName}\" could not be created!",
                    title: "Unable to create water",
                    icon: MessageBoxIcon.Error
                    );
            }
            finally
            {
                materialButtonCreateWater.Enabled = false;
                dbContext?.Dispose();
            }
        }
    }
}
