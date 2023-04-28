using FPIS.Models;
using FPIS.Services;
using System.ComponentModel;

namespace FPIS.Views
{
    public partial class AddAnalysisResultForm : Form
    {
        private Sample? _sample;
        private readonly string _sampleId;
        private readonly string _sampleType;
        private string _productId;
        private User? _productionEngineer1;
        private User? _productionEngineer2;
        private readonly UserService _userService;
        private readonly AnalysisService _analysisService;
        public static BindingList<AnalysisResultSampleDetailBindingItem>_sampleDetails = new();

        public AddAnalysisResultForm(string sampleId = "", string sampleType = "")
        {
            _sampleDetails.Clear();
            InitializeComponent();

            _sampleId = sampleId; // argument value or empty string
            _sampleType = sampleType.ToLower();
            AppDbContext dbContext = new();

            _userService = new(dbContext);
            _analysisService = new(dbContext);

            LoadSample();
            ViewSamplesRequestedUserControl.isRequestCompleted = false;
        }

        private void SetupInitialValues()
        {
            labelAnalysisResultTextAndId.Text =
                $"{labelAnalysisResultTextAndId.Text} " +
                $" {_sample.Date.DayOfWeek}, {_sample.Date.ToLongDateString()} @ " +
                $"{_sample.Time.ToLongTimeString()}";

            labelAnalysisType.Text = $"{_sample.TypeForFiltering} Analysis";
            labelStatus.Text = _sample.Status;
        }

        private void FetchProductionEngineer1()
        {
            if (_sample != null)
            {
                _productionEngineer1 = _userService.GetUserByEmployeeId(
                    _sample.Employee1
                );

                labelEngineer1.Text =
                    $"{_productionEngineer1?.FirstName} " +
                    $"{_productionEngineer1?.MiddleName}" +
                    $"{_productionEngineer1?.LastName}";
            }
        }

        private void FetchProductionEngineer2()
        {
            if (_sample != null)
            {
                _productionEngineer2 = _userService.GetUserByEmployeeId(
                    _sample.Employee2
                );

                labelEngineer2.Text =
                    $"{_productionEngineer2?.FirstName} " +
                    $"{_productionEngineer2?.MiddleName}" +
                    $"{_productionEngineer2?.LastName}";
            }
        }

        private void SetupSampleDetails()
        {
            _sample.SampleDetails.ForEach(sd => {
                string itemName = "";

                if (_sample.TypeForFiltering.ToLower() == "production")
                {
                    itemName = sd.AnalysisItem.AnalysisProducts[0].Product.ProductName;
                }

                if (_sample.TypeForFiltering.ToLower() == "water")
                {
                    itemName = sd.AnalysisItem.AnalysisWaters[0].Water.WaterName;
                }

                _sampleDetails.Add(
                    new()
                    {
                        Id = sd.Id,
                        Name = itemName,
                        AnalysisItemId = sd.AnalysisItemId.ToString()
                    }
                );
            });
            
            dataGridView1.DataSource = _sampleDetails;
        }

        private void LoadSample()
        {
            if (_sampleType.ToLower() == "water")
            {
                _sample = _analysisService.FetchWaterAnalysis(_sampleId);
            }
            else if (_sampleType.ToLower() == "production")
            {
                _sample = _analysisService.FetchProductionAnalysis(_sampleId);
            }

            if (_sample == null)
            {
                DialogResult dialogResult = Utils.Utils.ShowMessageBox(
                    "We could not find the \"Analysis Request\" you selected",
                    "Analysis Request Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // this is a work around, because the user
                // can click on the close button to dismiss
                // this dialog
                if (dialogResult != DialogResult.Yes)
                {
                    Close();
                }
                return;
            }

            SetupInitialValues();
            SetupSampleDetails();
            FetchProductionEngineer1();
            if (_sample.Employee1 == _sample.Employee2)
            {
                ProductionEngineerOneCaptionControl.Text = "Procurement Officer";
                ProductionEngineerTwoCaptionControl.Visible =
                    labelEngineer2.Visible = false;
                return;
            }
            FetchProductionEngineer2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.ColumnIndex == row.Cells.Count - 1)
            {
                DataGridViewRow activeRow = dataGridView1.Rows[e.RowIndex];
                string itemId = activeRow.Cells[0].Value.ToString();
                string itemName = activeRow.Cells[1].Value.ToString();
                string analysisItemId = activeRow.Cells[2].Value.ToString();

                if (_sample.TypeForFiltering.ToLower() == "production")
                {
                    _productId = _sample.SampleDetails.FirstOrDefault(sd => sd.Id.ToString() == itemId)
                        .AnalysisItem
                        .AnalysisProducts
                        .FirstOrDefault()
                        .ProductId.ToString();
                }
                else if (_sample.TypeForFiltering.ToLower() == "water")
                {
                    _productId = _sample.SampleDetails.FirstOrDefault(sd => sd.Id.ToString() == itemId)
                        .AnalysisItem
                        .AnalysisWaters
                        .FirstOrDefault()
                        .WaterId.ToString();
                }

                AnalysisResultSampleDetailBindingItem sdbi =
                    _sampleDetails.FirstOrDefault(sd => sd.Id.ToString() == itemId);

                new AddAnalysisParameterValues(
                    itemId,
                    itemName,
                    analysisItemId,
                    _sampleType
                , _productId
                ).ShowDialog();
            }
        }

        private void materialButtonGenerateResult_Click(object sender, EventArgs e)
        {
            ViewSamplesRequestedUserControl.isRequestCompleted = false;
            DialogResult dialogResult = Utils.Utils.ShowMessageBox(
                "Are you sure about you want create a result now?",
                "Generate Analysis Result?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _analysisService.CreateSampleResult(_sampleId, Main.LOGGED_USER_ID, _sampleDetails.ToList());
                _analysisService.SetSampleAsComplete(_sampleId);

                Utils.Utils.ShowMessageBox(
                    "Analysis Result is successfully generated.",
                    "Analysis Result Generated"
                );
                ViewSamplesRequestedUserControl.isRequestCompleted= true;
            }
            catch (Exception ex)
            {
                Utils.Utils.ShowMessageBox(
                    "An error occurred when generating the result for this analysis. Please try again." + ex,
                    "Error Occurred!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
