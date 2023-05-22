using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class AddAnalysisResultForm : MaterialForm
    {
        private Sample? _sample;
        private SampleResult? _sampleResult;
        private readonly string analysisId;
        private readonly string _sampleType;
        private readonly bool _shouldUpdate;
        private string productOrWaterId;
        private User? _productionEngineer1;
        private User? _productionEngineer2;
        private readonly UserService _userService;
        private readonly AnalysisService _analysisService;
        public static BindingList<AnalysisResultSampleDetailBindingItem>_sampleItems = new();

        public AddAnalysisResultForm(
            string analysisId = "",
            string sampleType = "",
            bool shouldUpdateAnalysisResult = false
        )
        {
            _sampleItems.Clear();
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);

            _shouldUpdate = shouldUpdateAnalysisResult;
            this.analysisId = analysisId; // argument value or empty string
            _sampleType = sampleType.ToLower();
            AppDbContext dbContext = new();

            _userService = new(dbContext);
            _analysisService = new(dbContext);

            if (shouldUpdateAnalysisResult)
            {
                LoadSampleResult();
            } else
            {
                LoadSample();
            }
            ViewSamplesRequestedUserControl.isRequestCompleted = false;
        }

        private void SetupInitialValues(
            DateOnly analysisDate,
            TimeOnly analysisTime,
            string analysisType,
            string analysisStatus
        )
        {
            string textPrefix = !_shouldUpdate ? "Add Analysis Result for Request: " : "Update Analysis Result: ";
            Text =
                $"{textPrefix} " +
                $"{analysisDate.ToLongDateString()} @ " +
                $"{analysisTime.ToLongTimeString()}";

            labelAnalysisType.Text = $"{analysisType} Analysis";
            labelStatus.Text = analysisStatus;
            materialButtonGenerateResult.Text = !_shouldUpdate ? "Generate Analysis Result" : "Update Analysis Result"; ;
            Text = !_shouldUpdate ? "Add Analysis Result" : "Update Analysis Result";
        }

        private void SetProductionEngineerLabel(string employeeId, Label label)
        {
            _productionEngineer1 = _userService.GetUserByEmployeeId(employeeId);

            label.Text =
                $"{_productionEngineer1?.FirstName} " +
                $"{_productionEngineer1?.MiddleName}" +
                $"{_productionEngineer1?.LastName}";
        }

        // Gets the product or water name from a sample detail or sample result detail
        private string GetItemName(string analysisType, AnalysisItem analysisItem)
        {
            if (analysisItem == null)
            {
                // throw new ArgumentException($"analysisItem cannot be null");
                return "No Name";
            }

            string itemName = "";
            analysisType = analysisType.ToLower();

            if (analysisType == "production")
            {
                itemName = analysisItem.AnalysisProducts[0].Product.ProductName;
            }
            else if (analysisType.ToLower() == "water")
            {
                itemName = analysisItem.AnalysisWaters[0].Water.WaterName;
            }
            else
            {
                throw new ArgumentException($"{analysisItem} is not recognized, use \"water\" or \"production\"");
            }

            return itemName;
        }

        // Gets the product or water id from a sample detail or sample result detail
        private string GetItemId(string analysisType, AnalysisItem analysisItem)
        {
            if (analysisItem == null)
            {
                throw new ArgumentException($"analysisItem cannot be null");
            }

            string itemId = "";
            analysisType = analysisType.ToLower();

            if (analysisType == "production")
            {
                itemId = analysisItem.AnalysisProducts[0].ProductId.ToString();
            }
            else if (analysisType.ToLower() == "water")
            {
                itemId = analysisItem.AnalysisWaters[0].WaterId.ToString();
            }
            else
            {
                throw new ArgumentException($"{analysisItem} is not recognized, use \"water\" or \"production\"");
            }

            return itemId;
        }

        // Gets the parameter name or water name from a sample detail or sample result detail
        private string GetItemParameterName(string analysisType, AnalysisParameter analysisParameter)
        {
            if (analysisParameter == null)
            {
                // throw new ArgumentException($"analysisItem cannot be null");
                return "No Name";
            }

            string itemName = "";
            analysisType = analysisType.ToLower();

            if (analysisType == "production")
            {
                itemName = analysisParameter
                    .ProductAnalysisParameters
                    .FirstOrDefault()
                    ?.ProductParameter
                    ?.ParameterName ?? "No Parameter Name";
            }
            else if (analysisType.ToLower() == "water")
            {
                itemName = analysisParameter
                    .WaterAnalysisParameters
                    .FirstOrDefault()
                    ?.WaterParameter
                    ?.ParameterName ?? "No Parameter Name";
            }
            else
            {
                throw new ArgumentException($"{analysisParameter} is not recognized, use \"water\" or \"production\"");
            }

            return itemName;
        }


        private void SetupSampleDetails(List<SampleDetail> sampleDetails)
        {
            sampleDetails.ForEach(sd => {
                string itemName = GetItemName(sd.Sample.TypeForFiltering, sd.AnalysisItem);
                string itemId = GetItemId(sd.Sample.TypeForFiltering, sd.AnalysisItem);

                _sampleItems.Add(
                    new()
                    {
                        Id = sd.Id,
                        Name = itemName,
                        Label = sd.Label,
                        ProductOrWaterId = itemId,
                        AnalysisItemId = sd.AnalysisItemId.ToString()
                    }
                );
            });

            dataGridView1.DataSource = _sampleItems;
        }

        private void SetupSampleResultDetails(List<SampleResultDetail> sampleResultDetails)
        {
            sampleResultDetails.ForEach(srd => {
                string itemName = GetItemName(srd.SampleResult.Sample.TypeForFiltering, srd.AnalysisItem);
                string itemId = GetItemId(srd.SampleResult.Sample.TypeForFiltering, srd.AnalysisItem);

                _sampleItems.Add(
                    new()
                    {
                        Id = srd.Id,
                        Name = itemName,
                        Label = srd.Label,
                        ProductOrWaterId = itemId,
                        Reject = srd.IsRejected ? "Rejected" : "Active",
                        AnalysisItemId = srd.AnalysisItemId.ToString(),
                        parametersWithValues = _analysisService
                            .FetchSampleResultWithParameters(
                                srd.Id.ToString(),
                                srd.SampleResult.Sample.TypeForFiltering
                            ).Select(param => new ParametersWithValues()
                        {
                            ParameterId = param.AnalysisParameterId.ToString(),
                            ParameterValue = param.Value.ToString(),
                            AnalysisResultWithParameterId = param.Id.ToString(),
                            ParameterName = GetItemParameterName(srd.SampleResult.Sample.TypeForFiltering, param.AnalysisParameter)
                        }).ToList()
                    }
                );
            });

            dataGridView1.DataSource = _sampleItems.Select(it => { it.ParameterValues = it.ToString(); return it; }).ToList();
        }

        private void LoadSample()
        {
            string sampleType = _sampleType.ToLower();

            if (sampleType == "water")
            {
                _sample = _analysisService.FetchWaterAnalysis(analysisId);
            }
            else if (sampleType == "production")
            {
                _sample = _analysisService.FetchProductionAnalysis(analysisId);
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

            SetupInitialValues(_sample.Date, _sample.Time, _sample.TypeForFiltering, _sample.Status);
            SetupSampleDetails(_sample.SampleDetails);

            SetProductionEngineerLabel(_sample.Employee1, labelEngineer1);
            if (_sample.Employee1 == _sample.Employee2)
            {
                ProductionEngineerOneCaptionControl.Text = "Procurement Officer";
                ProductionEngineerTwoCaptionControl.Visible =
                    labelEngineer2.Visible = false;
                return;
            }
            SetProductionEngineerLabel(_sample.Employee2, labelEngineer2);
        }

        private void LoadSampleResult()
        {
            string sampleType = _sampleType.ToLower();

            if (sampleType == "water")
            {
                _sampleResult = _analysisService.FetchWaterAnalysisResult(analysisId);
            }
            else if (sampleType == "production")
            {
                _sampleResult = _analysisService.FetchProductionAnalysisResult(analysisId);
            }

            if (_sampleResult == null)
            {
                DialogResult dialogResult = Utils.Utils.ShowMessageBox(
                    "We could not find the \"Analysis Request\" you want to update.",
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

            SetupInitialValues(
                _sampleResult.Date,
                _sampleResult.Time,
                _sampleResult.Sample.TypeForFiltering,
                _sampleResult.Sample.Status
            );
            SetupSampleResultDetails(_sampleResult.SampleResultDetails);

            SetProductionEngineerLabel(_sampleResult.Sample.Employee1, labelEngineer1);
            if (_sampleResult.Sample.Employee1 == _sampleResult.Sample.Employee2)
            {
                ProductionEngineerOneCaptionControl.Text = "Procurement Officer";
                ProductionEngineerTwoCaptionControl.Visible =
                    labelEngineer2.Visible = false;
                return;
            }
            SetProductionEngineerLabel(_sampleResult.Sample.Employee2, labelEngineer2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row != null)
            {
                DataGridViewRow activeRow = dataGridView1.Rows[e.RowIndex];
                string itemId = row.Cells["sampleIdDataGridViewTextBoxColumn1"].Value.ToString();
                string itemName = activeRow.Cells["nameDataGridViewTextBoxColumn1"].Value.ToString();
                string analysisItemId = activeRow.Cells["analysisItemIdDataGridViewTextBoxColumn"].Value.ToString();
                string productOrWaterId = activeRow.Cells["productOrWaterIdDataGridViewTextBoxColumn"].Value.ToString();

                if (row.Cells["parameterValuesDataGridViewColumn"].Selected)
                {
                    AnalysisResultSampleDetailBindingItem sdbi =
                        _sampleItems.FirstOrDefault(sd => sd.Id.ToString() == itemId);

                    new AddAnalysisParameterValues(
                        itemId,
                        itemName,
                        analysisItemId,
                        _sampleType,
                        sdbi,
                        productOrWaterId,
                        _shouldUpdate
                    ).ShowDialog();
                }
                else if (row.Cells["rejectSampleResultDetail"].Selected)
                {
                    string value = row.Cells["rejectSampleResultDetail"].Value.ToString();
                    AnalysisResultSampleDetailBindingItem item = _sampleItems.First(it => it.Id.ToString().Equals(itemId));

                    if (value.Equals("Allow Sample")) {
                        item.isRejected = false;
                        row.Cells["rejectSampleResultDetail"].Value = "Reject Sample";
                    } else
                    {
                        item.isRejected = true;
                        row.Cells["rejectSampleResultDetail"].Value = "Allow Sample";
                    }
                }
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
                if (_shouldUpdate)
                {
                    IEnumerable<SampleResultsDetailsWithParameter> sampleResultsDetailsWithParameters = new List<SampleResultsDetailsWithParameter>();
                    List<SampleResultsDetailsWithParameter> filteredParameterWithValues = new();

                    _sampleItems.ToList().ForEach(sampleItem =>
                    {
                        if (sampleItem != null)
                        {
                            sampleResultsDetailsWithParameters = sampleResultsDetailsWithParameters.Concat(
                                sampleItem.parametersWithValues
                                .Where(paramWithValue => !string.IsNullOrEmpty(paramWithValue.AnalysisResultWithParameterId))
                                .Select(paramWithValue => new SampleResultsDetailsWithParameter()
                                {
                                    Id = new Guid(paramWithValue.AnalysisResultWithParameterId),
                                    Value = float.Parse(paramWithValue.ParameterValue)
                                })
                            );

                            filteredParameterWithValues = sampleItem.parametersWithValues
                                .Where(pmw => string.IsNullOrEmpty(pmw.AnalysisResultWithParameterId))
                                .Select(pmw => new SampleResultsDetailsWithParameter()
                                {
                                    Value = float.Parse(pmw.ParameterValue),
                                    SampleResultDetailId = sampleItem.Id,
                                    AnalysisParameterId = new Guid(pmw.ParameterId),
                                }).ToList();
                        }
                    });

                    if (_sampleResult != null)
                    {
                        _analysisService.UpdateSampleResult(
                            sampleResultsDetailsWithParameters.ToList(),
                            filteredParameterWithValues
                        );
                        DialogResult result = Utils.Utils.ShowMessageBox(
                            "Analysis Result is successfully updated.",
                            "Analysis Result Updated"
                        );
                    }
                }
                else
                {
                    _analysisService.CreateSampleResult(analysisId, Main.LOGGED_USER_ID, _sampleItems.ToList());

                    if (_sampleItems.All(it => it.isRejected))
                    {
                        _analysisService.SetSampleAsComplete(analysisId, "Rejected");
                    } else if (_sampleItems.Any(it => it.isRejected))
                    {
                        _analysisService.SetSampleAsComplete(analysisId, "Completed with Rejections");
                    } else
                    {
                        _analysisService.SetSampleAsComplete(analysisId, "Completed");
                    }

                    Utils.Utils.ShowMessageBox(
                        "Analysis Result is successfully generated.",
                        "Analysis Result Generated"
                    );
                    ViewSamplesRequestedUserControl.isRequestCompleted = true;
                }

                Close();
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
