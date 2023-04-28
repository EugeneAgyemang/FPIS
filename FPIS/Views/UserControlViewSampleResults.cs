using FPIS.Services;
using FPIS.Models;

namespace FPIS.Views
{
    public partial class UserControlViewSampleResults : UserControl
    {
        private readonly AnalysisService _analysisService;
        private readonly UserService _userService;
        private List<SampleResult> _sampleResultList;
        private List<AnalysisResultDataBindingItem> _sampleResults;

        public UserControlViewSampleResults()
        {
            InitializeComponent();

            AppDbContext dbContext = new();
            _analysisService = new(dbContext);
            _userService = new(dbContext);

            FetchAnalysisResults();
        }

        void FetchAnalysisResults()
        {
            _sampleResults = _analysisService.FetchSampleResults()
                .Select(sr =>
                {
                    User prodEngineer1 = _userService.GetUserByEmployeeId(sr.Sample.Employee1);
                    User prodEngineer2 = _userService.GetUserByEmployeeId(sr.Sample.Employee2);
                    AnalysisResultDataBindingItem u = new()
                    {
                        ProductionEngineerOne = $"{prodEngineer2?.FirstName} {prodEngineer2?.LastName}",
                        ProductionEngineerTwo = $"{prodEngineer1?.FirstName} {prodEngineer1?.LastName}",
                        SampleResultId = sr.Id.ToString(),
                        Name = $"{sr.User.FirstName} {sr.User.MiddleName} {sr.User.LastName}",
                        AnalysisType = sr.Sample.TypeForFiltering,
                        ResultDate = $"{sr.Date.ToLongDateString()} @ {sr.Time.ToShortTimeString()}",
                        Sample = $"{sr.Sample.Date.ToLongDateString()} @ {sr.Sample.Time.ToShortTimeString()}"
                    };

                    return u;
                })
                .ToList();

            dataGridView1.DataSource = _sampleResults;
            labelSampleResultsTotal.Text = _sampleResults?.Count().ToString() ?? "0";
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row != null && row.Cells["updateDataGridViewTextBoxColumn"].Selected)
            {
                string sampleResultId = row.Cells["sampleResultIdDataGridViewTextBoxColumn"].Value.ToString();
                string analysisType = row.Cells["analysisTypeDataGridViewTextBoxColumn"].Value.ToString().ToLower();

                new AddAnalysisResultForm(
                    sampleResultId,
                    analysisType,
                    shouldUpdateAnalysisResult: true
                ).Show();
            }
        }
    }
}
