using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class AddAnalysisSampleFormForFinishedProducts : MaterialForm
    {
        private readonly AnalysisSampleBindingItem[] selectedSamples;
        private readonly AnalysisItemService _analysisItemService;
        private readonly BindingList<AnalysisSampleBindingItem> itemList = new();

        public string AnalysisType { get; set; }
        public AddAnalysisSampleFormForFinishedProducts()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);

            dataGridView1.DataSource = itemList;

            /*
             * Copy the analysisItems to selectedSamples as an array and clear
             * the analysisItems because for some weird reason, the analysisItems
             * become different in the dataGridView when this Form is started.
             */
            selectedSamples = CreateAnalysisRequestFinishedProducts.analysisItemList.ToArray();
            CreateAnalysisRequestFinishedProducts.analysisItemList.Clear();


            _analysisItemService = new(new AppDbContext());

            if (CreateAnalysisRequestFinishedProducts.analysisType == "Production")
            {
                LoadAnalysisProducts();
            }
            else if (CreateAnalysisRequestFinishedProducts.analysisType == "Water")
            {
               // LoadAnalysisWaters();
            }
        }

        private void LoadAnalysisProducts()
        {
            List<AnalysisProduct> analysisProducts = _analysisItemService.FetchAnalysisProducts();

            foreach (AnalysisProduct ap in analysisProducts)
            {
                var existingItem = selectedSamples.FirstOrDefault(it => it.Id == ap.AnalysisItemId);

                AnalysisSampleBindingItem newItem = new()
                {
                    Id = ap.AnalysisItemId,
                    Name = ap.Product.ProductName,
                    Selected = existingItem != null
                };

                itemList.Add(newItem);

                if (existingItem != null)
                {
                    CreateAnalysisRequestFinishedProducts.analysisItemList.Add(newItem);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
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
                CreateAnalysisRequestFormUserControl.analysisItemList.Remove(it);
            }
            else
            {
                item.Selected = true;
                AnalysisSampleBindingItem it = itemList.First(aI => aI.Id.ToString() == itemId);
                CreateAnalysisRequestFormUserControl.analysisItemList.Add(it);
            }
        }
    }
}
