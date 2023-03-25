using FPIS.Models;
using FPIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPIS.Views
{
    public partial class AddAnalysisParameterValues : Form
    {
        private readonly string _itemName;
        private readonly string _analysisType;
        private readonly string _sampleDetailId;
        private readonly string _analysisItemId;
        private readonly AnalysisParameterService _analysisParameterService;
        private readonly BindingList<AnalysisSampleParameterBindingItem> _parameterList = new();

        public AddAnalysisParameterValues(
            string sampleDetailId,
            string itemName,
            string analysisItemId,
            string analysisType
        )
        {
            InitializeComponent();
            _itemName = itemName;
            _analysisType = analysisType;
            _sampleDetailId = sampleDetailId;
            _analysisItemId = analysisItemId;

            labelItemName.Text += $" \"{_itemName}\"";
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
                LoadProductParameters();
            }
            else if (lowerAnalysisType.Equals("water"))
            {
                dataGridView1.Columns["methodColumn"].Visible = false;
                dataGridView1.Columns["specificationColumn"].Visible = false;
                LoadWaterParameters();
            }
        }

        void LoadWaterParameters() 
        {
            _analysisParameterService.FetchAnalysisWaterParameters()
                .ForEach(ap => {
                    AnalysisResultSampleDetailBindingItem? d =
                    AddAnalysisResultForm._sampleDetails
                        .FirstOrDefault(sd => sd.Id.ToString() == _sampleDetailId);

                    string value = d.parametersWithValues
                    .FirstOrDefault(pwv => pwv.ParameterId.Equals(ap.AnalysisParameterId))?.ParameterValue ?? "0.00";

                    _parameterList.Add(new() {
                        Id = ap.AnalysisParameterId,
                        Unit = ap.WaterParameter.Unit,
                        Value = value,
                        Name = ap.WaterParameter.ParameterName,
                        ControlLimit = ap.WaterParameter.ControlLimit
                    });
                });
        }

        void LoadProductParameters()
        {
            _analysisParameterService.FetchProductAnalysisParameters()
                .ForEach(ap => {
                    AnalysisResultSampleDetailBindingItem? d =
                        AddAnalysisResultForm._sampleDetails
                        .FirstOrDefault(sd => sd.Id.ToString() == _sampleDetailId);

                    string value = d.parametersWithValues
                    .FirstOrDefault(pwv => pwv.ParameterId.Equals(ap.AnalysisParameterId))?.ParameterValue ?? "0.00";

                    d.parametersWithValues.ForEach(p =>
                    {
                        if (ap.AnalysisParameterId.Equals(p.ParameterId))
                        {
                            MessageBox.Show(p.ParameterId + " " + ap.AnalysisParameterId);
                        }
                    });

                    _parameterList.Add(new() {
                        Value = value,
                        Id = ap.AnalysisParameterId,
                        Unit = ap.ProductParameter.Unit,
                        Method = ap.ProductParameter.Method,
                        Name = ap.ProductParameter.ParameterName,
                        Specification = ap.ProductParameter.Specification
                    });
                });
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

                if (String.IsNullOrEmpty(enteredValue))
                {
                    return;
                }

                AnalysisSampleParameterBindingItem selectedItem =
                    _parameterList.First(item => item.Id.ToString() == analysisParameterId);

                selectedItem.Value = enteredValue;
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void materialButtonSaveAndClose_Click(object sender, EventArgs e)
        {
            AnalysisResultSampleDetailBindingItem bindingItem =
                AddAnalysisResultForm._sampleDetails.First(sd => sd.Id.ToString() == _sampleDetailId);

            bindingItem.parametersWithValues.Clear();

            _parameterList.ToList().ForEach(parameterBinding => {
                bindingItem.parametersWithValues.Add(
                    new ParametersWithValues() 
                    {
                        ParameterId = parameterBinding.Id.ToString(),
                        ParameterName = parameterBinding.Name,
                        ParameterValue = parameterBinding.Value ?? "0.00"
                    }
                );
            });

            bindingItem.ParameterValues = bindingItem.ToString();

            // use this trick to update the _sampleDetails collection
            // because C# only does change detection when an item is
            // added or deleted. If not this, then the parameter values
            // are not update after this form is closed.
            AddAnalysisResultForm._sampleDetails.Remove(bindingItem);
            AddAnalysisResultForm._sampleDetails.Add(bindingItem);

            Close();
        }
    }
}
