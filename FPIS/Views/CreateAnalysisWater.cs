using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace FPIS.Views
{
    public partial class CreateAnalysisWater : MaterialForm
    {
        private readonly WaterService _waterService;
        private readonly AnalysisItemService _analysisItemService;

        public CreateAnalysisWater()
        {
            InitializeComponent();

            AppDbContext dbContext = new();
            _waterService = new(dbContext);
            _analysisItemService = new(dbContext);

            LoadAllWater();
        }

        private void LoadAllWater()
        {
            materialComboBoxWater.DataSource = _waterService.GetAllWater();
            materialComboBoxWater.DisplayMember = "WaterName";
        }

        private void materialButtonAddAnalysisWater_Click(object sender, EventArgs e)
        {
            try
            {
                string waterName = materialComboBoxWater.Text;
                Water? water = _waterService.GetWaterByName(waterName);

                if (water == null)
                {
                    Utils.Utils.ShowMessageBox(
                        $"\"{waterName}\" does not exist in our database. Add it and try again.",
                        "Water Does Not Exist",
                        icon: MessageBoxIcon.Exclamation
                        );
                    return;
                }

                if (_analysisItemService.IsWaterAnAnalysisItem(water))
                {
                    MessageBox.Show(
                        $"\"{waterName}\" is already an analysis item",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                    return;
                }

                DialogResult dialogResult = Utils.Utils.ShowMessageBox(
                    $"Do you want to add \"{waterName}\" as a new analysis water?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _analysisItemService.CreateAnalysisWater(water);

                Utils.Utils.ShowMessageBox(
                    $"\"{waterName}\" is successfully added as Analysis Item",
                    "Success",
                    icon: MessageBoxIcon.Information
                    );

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ${ex}");
            }

        }
    }
}
