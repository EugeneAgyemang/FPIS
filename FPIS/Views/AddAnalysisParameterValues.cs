using FPIS.Models;
using FPIS.Services;
using System.ComponentModel;

namespace FPIS.Views
{
    public partial class AddAnalysisParameterValues : Form
    {
        private readonly string _itemName;
        private readonly string _analysisType;
        private readonly string _sampleDetailId;
        private readonly string _analysisItemId;
        private readonly string _waterOrProductId;
        private readonly bool _shouldUpdate;
        private readonly AnalysisParameterService _analysisParameterService;
        private readonly AnalysisResultSampleDetailBindingItem _selectedBindingItem;
        private BindingList<AnalysisSampleParameterBindingItem> _parameterList = new();

        // this will contain new parameters that were not created when the analysis result
        // was created.
        private readonly BindingList<AnalysisSampleParameterBindingItem> _newParameterList = new();
        private readonly BindingList<AnalysisSampleParameterBindingItem> _oldParameterList = new();

        public AddAnalysisParameterValues(
            string sampleDetailId,
            string itemName,
            string analysisItemId,
            string analysisType,
            AnalysisResultSampleDetailBindingItem selectedBindingItem,
            string waterOrProductId,
            bool shouldUpdate
        )
        {
            InitializeComponent();
            _selectedBindingItem = selectedBindingItem;
            _itemName = itemName;
            _analysisType = analysisType;
            _sampleDetailId = sampleDetailId;
            _analysisItemId = analysisItemId;
            _waterOrProductId = waterOrProductId;
            _shouldUpdate = shouldUpdate;
            materialCheckboxShowNewParameters.Visible = false;

            if (!_shouldUpdate)
            {
                labelItemName.Text += $" \"{_itemName}\"";
            }
            else
            {
                labelItemName.Text = $"Update Parameter Values for: \"{_itemName}\"";
            }

            dataGridView1.DataSource = _parameterList;

            AppDbContext dbContext = new();
            _analysisParameterService = new(dbContext);

            LoadAnalysisParameters();
        }

        void LoadAnalysisParameters()
        {
            string lowerAnalysisType = _analysisType.ToLower();

            if (lowerAnalysisType.Equals("production"))
            {
                dataGridView1.Columns["ControlLimitColumn"].Visible = false;
                LoadProductParameters(_selectedBindingItem);
            }
            else if (lowerAnalysisType.Equals("water"))
            {
                dataGridView1.Columns["methodColumn"].Visible = false;
                dataGridView1.Columns["specificationColumn"].Visible = false;
                LoadWaterParameters(_selectedBindingItem);
            }
        }

        void LoadWaterParameters(AnalysisResultSampleDetailBindingItem bindingItem)
        {
            IEnumerable<WaterAnalysisParameter> waterAnalysisParameters =
            _analysisParameterService.FetchAnalysisWaterParameters(Guid.Parse(_waterOrProductId));

            foreach (WaterAnalysisParameter waterAnalysisParameter in waterAnalysisParameters)
            {
                ParametersWithValues? item = bindingItem.parametersWithValues
                    .FirstOrDefault(pwv => pwv.ParameterId.Equals(waterAnalysisParameter.AnalysisParameterId.ToString()));

                if(_shouldUpdate)
                {
                    if (!string.IsNullOrEmpty(item?.AnalysisResultWithParameterId))
                    {
                        _oldParameterList.Add(new()
                        {
                            Id = waterAnalysisParameter.AnalysisParameterId,
                            Unit = waterAnalysisParameter.WaterParameter.Unit,
                            Value = item?.ParameterValue ?? "0.00",
                            Name = waterAnalysisParameter.WaterParameter.ParameterName,
                            ControlLimit = waterAnalysisParameter.WaterParameter.ControlLimit,
                            shouldUpdate = true,
                        });
                    }
                    else
                    {
                        _newParameterList.Add(new()
                        {
                            Id = waterAnalysisParameter.AnalysisParameterId,
                            Unit = waterAnalysisParameter.WaterParameter.Unit,
                            Value = item?.ParameterValue ?? "0.00",
                            Name = waterAnalysisParameter.WaterParameter.ParameterName,
                            ControlLimit = waterAnalysisParameter.WaterParameter.ControlLimit,
                            shouldUpdate = false,
                        });
                    }

                    if (_newParameterList.Count > 0)
                    {
                        materialCheckboxShowNewParameters.Visible = true;
                    };

                    _parameterList = _oldParameterList;
                    dataGridView1.DataSource = _parameterList;
                } else
                {
                    _parameterList.Add(new()
                    {
                        Id = waterAnalysisParameter.AnalysisParameterId,
                        Unit = waterAnalysisParameter.WaterParameter.Unit,
                        Value = item?.ParameterValue ?? "0.00",
                        Name = waterAnalysisParameter.WaterParameter.ParameterName,
                        ControlLimit = waterAnalysisParameter.WaterParameter.ControlLimit,
                        shouldUpdate = false,
                    });

                    materialCheckboxShowNewParameters.Visible = false;
                    dataGridView1.DataSource = _parameterList;
                }
            }
        }

        void LoadProductParameters(AnalysisResultSampleDetailBindingItem bindingItem)
        {
            IEnumerable<ProductAnalysisParameter> productAnalysisParameters =
                _analysisParameterService.FetchProductAnalysisParameters(Guid.Parse(_waterOrProductId));

            foreach(ProductAnalysisParameter productAnalysisParameter in productAnalysisParameters)
            {
                ParametersWithValues? item = bindingItem.parametersWithValues
                    .FirstOrDefault(pwv => pwv.ParameterId.Equals(productAnalysisParameter.AnalysisParameterId.ToString()));

                if (_shouldUpdate)
                {
                    if (!string.IsNullOrEmpty(item?.AnalysisResultWithParameterId))
                    {
                        _oldParameterList.Add(new()
                        {
                            Value = item?.ParameterValue ?? "0.00",
                            Id = productAnalysisParameter.AnalysisParameterId,
                            Unit = productAnalysisParameter.ProductParameter.Unit,
                            Method = productAnalysisParameter.ProductParameter.Method,
                            Name = productAnalysisParameter.ProductParameter.ParameterName,
                            Specification = productAnalysisParameter.ProductParameter.Specification,
                            shouldUpdate = true,
                        });
                    }
                    else
                    {
                        _newParameterList.Add(new()
                        {
                            Value = item?.ParameterValue ?? "0.00",
                            Id = productAnalysisParameter.AnalysisParameterId,
                            Unit = productAnalysisParameter.ProductParameter.Unit,
                            Method = productAnalysisParameter.ProductParameter.Method,
                            Name = productAnalysisParameter.ProductParameter.ParameterName,
                            Specification = productAnalysisParameter.ProductParameter.Specification,
                            shouldUpdate = false,
                        });
                    }
                    if (_newParameterList.Count > 0)
                    {
                        materialCheckboxShowNewParameters.Visible = true;
                    };

                    _parameterList = _oldParameterList;
                    dataGridView1.DataSource = _parameterList;
                } else
                {
                    _parameterList.Add(new()
                    {
                        Value = item?.ParameterValue ?? "0.00",
                        Id = productAnalysisParameter.AnalysisParameterId,
                        Unit = productAnalysisParameter.ProductParameter.Unit,
                        Method = productAnalysisParameter.ProductParameter.Method,
                        Name = productAnalysisParameter.ProductParameter.ParameterName,
                        Specification = productAnalysisParameter.ProductParameter.Specification,
                        shouldUpdate = false,
                    });

                    materialCheckboxShowNewParameters.Visible = false;
                    dataGridView1.DataSource = _parameterList;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow activeRow = dataGridView1.Rows[e.RowIndex];

            if (e.ColumnIndex == activeRow.Cells.Count - 1) // the last cell
            {
                string analysisParameterId = activeRow.Cells[0].Value.ToString();
                string parameterName = activeRow.Cells[1].Value.ToString();
                string enteredValue = activeRow.Cells[activeRow.Cells.Count - 1].Value?.ToString();

                if (string.IsNullOrEmpty(enteredValue))
                {
                    return;
                }

                AnalysisSampleParameterBindingItem? selectedItem =
                    _parameterList.FirstOrDefault(item => item?.Id.ToString() == analysisParameterId);

                if (selectedItem != null)
                {
                    selectedItem.Value = enteredValue;
                }
            }
        }

        private void materialButtonSaveAndClose_Click(object sender, EventArgs e)
        {
            DialogResult userOption = Utils.Utils.ShowMessageBox("Do you wish to proceed?"
                , "Confirm Proceed"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if(userOption == DialogResult.No)
            {
                return;
            }

            _parameterList.ToList().ForEach(parameterBinding => {
                ParametersWithValues? item = _selectedBindingItem.parametersWithValues
                    .FirstOrDefault(pw => pw.ParameterId == parameterBinding.Id.ToString());

                if (!materialCheckboxShowNewParameters.Checked)
                {
                    _selectedBindingItem.parametersWithValues = _selectedBindingItem.parametersWithValues.Where(
                        it => !string.IsNullOrEmpty(it.AnalysisResultWithParameterId)
                    ).ToList();
                }

                if (item != null) {
                    item.ParameterValue = parameterBinding.Value ?? "0.00";
                    item.ParameterId = parameterBinding.Id.ToString();
                    item.ParameterName = parameterBinding.Name;
                }
                else
                {
                    _selectedBindingItem.parametersWithValues.Add(
                        new ParametersWithValues()
                        {
                            ParameterId = parameterBinding.Id.ToString(),
                            ParameterName = parameterBinding.Name,
                            ParameterValue = parameterBinding.Value ?? "0.00"
                        }
                    );
                }
            });

            _selectedBindingItem.ParameterValues = _selectedBindingItem.ToString();

            // use this trick to update the _sampleDetails collection
            // because C# only does change detection when an item is
            // added or deleted. If not this, then the parameter values
            // are not updated after this form is closed.
            AddAnalysisResultForm._sampleItems.Remove(_selectedBindingItem);
            AddAnalysisResultForm._sampleItems.Add(_selectedBindingItem);

            Close();
        }

        private void materialCheckboxShowNewParameters_CheckedChanged(object sender, EventArgs e)
        {
            if(materialCheckboxShowNewParameters.Checked)
            {
                _parameterList = new BindingList<AnalysisSampleParameterBindingItem>(_oldParameterList.Concat(_newParameterList).ToList());
                dataGridView1.DataSource = _parameterList;
            } else
            {
                _parameterList = new BindingList<AnalysisSampleParameterBindingItem>(_oldParameterList);
                dataGridView1.DataSource = _parameterList;
            }
        }
    }
}
