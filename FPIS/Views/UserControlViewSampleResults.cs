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
            DisableTimeFilter();
            
        }
        void FetchAnalysisResults()
        {
            if (materialRadioButtonProductAnalysis.Checked)
            {
                _sampleResults = _analysisService.FetchProductSampleResults()
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

                //labelSampleResultsTotal.Text = _sampleResults?.Count().ToString() ?? "No results available";
                labelSampleResultsTotal.Text = _sampleResults?.Count() == 0 ? "No results available" : ($"{_sampleResults?.Count()} result{((_sampleResults?.Count() > 1) ? "s" : "")} available");
            }
            else
            {
                _sampleResults = _analysisService.FetchWaterSampleResults()
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

                //labelSampleResultsTotal.Text = _sampleResults?.Count().ToString() ?? "No results available";
                labelSampleResultsTotal.Text = _sampleResults?.Count() == 0 ? "No results available" : ($"{_sampleResults?.Count()} result{((_sampleResults?.Count() > 1) ? "s" : "")} available");
            }
        }

        void FetchAnalysisResultsByDate()
        {
            if (materialRadioButtonProductAnalysis.Checked)
            {
                _sampleResults = _analysisService.FetchProductSampleResultsByDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text))
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

                //labelSampleResultsTotal.Text = _sampleResults?.Count().ToString() ?? "No results available";
                labelSampleResultsTotal.Text = _sampleResults?.Count() == 0 ? "No results available" : ($"{_sampleResults?.Count()} result{((_sampleResults?.Count() > 1) ? "s" : "")} available");
            }
            else
            {
                _sampleResults = _analysisService.FetchWaterSampleResultsByDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text))
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

                //labelSampleResultsTotal.Text = _sampleResults?.Count().ToString() ?? "No results available";
                labelSampleResultsTotal.Text = _sampleResults?.Count() == 0 ? "No results available" : ($"{_sampleResults?.Count()} result{((_sampleResults?.Count() > 1) ? "s" : "")} available");
            }
        }

        TimeOnly _initialToTime, _finalToTime;
        void setToTime()
        {
            _initialToTime = TimeOnly.Parse(dateTimePickerToTime.Text);
            int initSeconds = _initialToTime.Second;
            int finalSeconds = 59 - initSeconds;
            _finalToTime = _initialToTime.Add(TimeSpan.FromSeconds(finalSeconds));
        }

        void FetchAnalysisResultsByTime()
        {
            setToTime();
            if (materialRadioButtonProductAnalysis.Checked)
            {
                _sampleResults = _analysisService.FetchProductSampleResultsByTime(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), TimeOnly.Parse(dateTimePickerFromTime.Text), _finalToTime)
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

                //labelSampleResultsTotal.Text = _sampleResults?.Count().ToString() ?? "No results available";
                labelSampleResultsTotal.Text = _sampleResults?.Count() == 0 ? "No results available" : ($"{_sampleResults?.Count()} result{((_sampleResults?.Count() > 1) ? "s" : "")} available");
            }
            else
            {
                _sampleResults = _analysisService.FetchWaterSampleResultsByTime(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), TimeOnly.Parse(dateTimePickerFromTime.Text), _finalToTime)
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

                //labelSampleResultsTotal.Text = _sampleResults?.Count().ToString() ?? "No results available";
                labelSampleResultsTotal.Text = _sampleResults?.Count() == 0 ? "No results available" : ($"{_sampleResults?.Count()} result{((_sampleResults?.Count() > 1) ? "s" : "")} available");
            }
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

        private void materialRadioButtonProductAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            DisableTimeFilter();
            FetchAnalysisResults();
        }

        private void materialRadioButtonWaterAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            DisableTimeFilter();
            FetchAnalysisResults();
        }

        private void materialButtonSearchAnalyticalResults_Click(object sender, EventArgs e)
        {
            FetchAnalysisResultsByDate();
            EnableTimeFilter();
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            FetchAnalysisResults();
            DisableTimeFilter();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            FetchAnalysisResultsByTime();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FetchAnalysisResultsByDate();
        }

        void DisableTimeFilter()
        {
            dateTimePickerFromTime.Enabled = false;
            dateTimePickerToTime.Enabled = false;
            materialButton1.Enabled = false;
            materialButton2.Enabled = false;
            groupBox2.Enabled = false;
        }

        void EnableTimeFilter()
        {
            dateTimePickerFromTime.Enabled = true;
            dateTimePickerToTime.Enabled = true;
            materialButton1.Enabled = true;
            materialButton2.Enabled = true;
            groupBox2.Enabled = true;
        }
    }
}
