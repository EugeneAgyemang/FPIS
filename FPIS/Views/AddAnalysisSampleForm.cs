using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using Moq;
using System.ComponentModel;

namespace FPIS.Views
{
    public partial class AddAnalysisSampleForm : MaterialForm
    {
        private readonly AnalysisItemService _analysisItemService;
        private readonly BindingList<AnalysisSampleBindingItem> itemList = new();

        public string AnalysisType { get; set; }

        public AddAnalysisSampleForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = itemList;

            _analysisItemService = new(new AppDbContext());

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
                var existingItem = CreateAnalysisRequestForm.analysisItemList.FirstOrDefault(it => it.Id == ap.AnalysisItemId);

                AnalysisSampleBindingItem newItem = new()
                {
                    Id = ap.AnalysisItemId,
                    Name = ap.Product.ProductName,
                    Selected = existingItem != null
                };

                itemList.Add(newItem);
            }
        }

        private void LoadAnalysisWaters()
        {
            List<AnalysisWater> analysisWaters = _analysisItemService.FetchAnalysisWater();

            foreach (AnalysisWater aw in analysisWaters)
            {
                var existingItem = CreateAnalysisRequestForm.analysisItemList.FirstOrDefault(it => it.Id == aw.AnalysisItemId);

                AnalysisSampleBindingItem newItem = new()
                {
                    Id = aw.AnalysisItemId,
                    Name = aw.Water.WaterName,
                    Selected = existingItem != null
                };

                itemList.Add(newItem);
            }
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

            // this is because it shows false before it turns to true
            // and vice-versa
            if (selectItemColumnValue.Equals("True"))
            {
                item.Selected = false;
                AnalysisSampleBindingItem it = itemList.First(it => it.Name == item.Name);
                CreateAnalysisRequestForm.analysisItemList.Remove(it);
                MessageBox.Show($"Hi item {item.Name}, it {it.Name}");
            }
            else
            {
                item.Selected = true;
                AnalysisSampleBindingItem it = itemList
                    .First(aI => aI.Id.ToString() == itemId);

                CreateAnalysisRequestForm.analysisItemList.Add(it);
                MessageBox.Show($"Hello  item {item.Name}, it {it.Name}");
            }
        }
    }
}
