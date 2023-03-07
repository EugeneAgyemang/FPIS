using FPIS.Models;
using FPIS.Services;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPIS.Views
{
    public partial class AddAnalysisSampleForm : Form
    {
        private readonly AnalysisItemService _analysisItemService;
        private readonly BindingList<AnalysisSampleBindingItem> itemList = new();
        public string AnalysisType { get; set; }

        public AddAnalysisSampleForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = itemList;

            AppDbContext context = new();
            _analysisItemService = new(context);

            if (CreateAnalysisRequestForm.analysisType == "Production")
            {
                LoadAnalysisProducts();
            } else if (CreateAnalysisRequestForm.analysisType == "Water")
            {
                LoadAnalysisWaters();
            }
        }
    
        private void LoadAnalysisProducts()
        {
            List<AnalysisProduct> analysisProducts = _analysisItemService.FetchAnalysisProducts();

            foreach (AnalysisProduct ap in analysisProducts)
            {
                var existingItem = CreateAnalysisRequestForm.analysisItemList.FirstOrDefault(it => it.Id == ap.Id);

                AnalysisSampleBindingItem newItem = new()
                {
                    Id = ap.AnalysisItemId,
                    Selected = existingItem != null,
                    Name = ap.Product.ProductName
                };
                /*
                var existingItem = CreateAnalysisForm.analysisItemList.FirstOrDefault(it => it.Id == new Guid());

                if (existingItem != null)
                {
                    newItem.Selected = true;
                    MessageBox.Show("matched");
                }
                */

                itemList.Add(newItem);
            }
        }

        private void LoadAnalysisWaters()
        {
            List<AnalysisWater> analysisWaters = _analysisItemService.FetchAnalysisWater();

            foreach (AnalysisWater analysisWater in analysisWaters)
            {
                AnalysisSampleBindingItem newItem = new()
                {
                    Id = analysisWater.AnalysisItemId,
                    Name = analysisWater.Water.WaterName
                };

                var existingItem = CreateAnalysisRequestForm.analysisItemList.FirstOrDefault(it => it.Id == new Guid());

                if (existingItem != null)
                {
                    newItem.Selected = true;
                }

                itemList.Add(newItem);
            }
        }

        private void analysisProductBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectItemColumnValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string itemId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            // only react if the user clicked on the select item column
            if (e.ColumnIndex != 2)
            {
                return;
            }

            var item = itemList.FirstOrDefault(it => it.Id.ToString() == itemId);

            if (item == null)
            {
                return;
            }

            if (selectItemColumnValue.Equals("True"))
            {
                item.Selected = false;
                var it = itemList.First(it => it.Id.ToString() == itemId);
                CreateAnalysisRequestForm.analysisItemList.Remove(it);
            }
            else
            {
                item.Selected = true;
                AnalysisSampleBindingItem analysisITem = itemList
                    .First(aI => aI.Id.ToString() == itemId);

                CreateAnalysisRequestForm.analysisItemList.Add(analysisITem);
            }
        }
    }
}
