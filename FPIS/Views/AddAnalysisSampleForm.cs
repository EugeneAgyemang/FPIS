using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using Moq;
using System.ComponentModel;
using System.Linq;

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

            if (CreateAnalysisRequestFormUserControl.analysisType == "Production")
            {
                LoadAnalysisProducts();
            } else if (CreateAnalysisRequestFormUserControl.analysisType == "Water")
            {
                LoadAnalysisWaters();
            }

            SetZeroQuantityCellsToReadOnly();
        }

        private void SetZeroQuantityCellsToReadOnly()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["addAnalysisSamplesQuantity"].Value.ToString() != "0")
                {
                    row.Cells["addAnalysisSamplesQuantity"].ReadOnly = false;
                }
                else
                {
                    row.Cells["addAnalysisSamplesQuantity"].ReadOnly = false;
                }
            }
        }
    
        private void LoadAnalysisProducts()
        {
            List<AnalysisProduct> analysisProducts = _analysisItemService.FetchAnalysisProducts();

            foreach (AnalysisProduct ap in analysisProducts)
            {
                var items = CreateAnalysisRequestFormUserControl.analysisItemList.Where(it => it.Id == ap.AnalysisItemId);

                int itemsCount = items?.Count() ?? 0;

                AnalysisSampleBindingItem newItem = new()
                {
                    Id = ap.AnalysisItemId,
                    Name = ap.Product.ProductName,
                    Selected = itemsCount > 0,
                    Quantity = itemsCount.ToString()
                };

                itemList.Add(newItem);
            }
        }

        private void LoadAnalysisWaters()
        {
            List<AnalysisWater> analysisWaters = _analysisItemService.FetchAnalysisWater();

            foreach (AnalysisWater aw in analysisWaters)
            {
                var items = CreateAnalysisRequestFormUserControl.analysisItemList.Where(it => it.Id == aw.AnalysisItemId);

                int itemsCount = items?.Count() ?? 0;

                AnalysisSampleBindingItem newItem = new()
                {
                    Id = aw.AnalysisItemId,
                    Name = aw.Water.WaterName,
                    Selected = itemsCount > 0,
                    Quantity = itemsCount.ToString()
                };

                itemList.Add(newItem);
            }
        }

        private void RemoveItems(string itemId, int currentQuantity, int newQuantity)
        {
            for (int i = newQuantity; i < currentQuantity; i++)
            {
                var itemToRemove = CreateAnalysisRequestFormUserControl.analysisItemList.Last(it => it.Id.ToString() == itemId);
                CreateAnalysisRequestFormUserControl.analysisItemList.Remove(itemToRemove);
            }
        }

        private void AddItems(AnalysisSampleBindingItem item, int currentQuantity, int newQuantity)
        {
            for (int i = currentQuantity + 1; i <= newQuantity; i++)
            {
                CreateAnalysisRequestFormUserControl.analysisItemList.Add(new()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Selected = true
                });
            }
        }

        void OnQuantityChanged(AnalysisSampleBindingItem item, int newQuantity)
        {
            int currentQuantity = CreateAnalysisRequestFormUserControl.analysisItemList
                .Where(it => it.Id == item.Id)
                .Count();

            if (newQuantity < currentQuantity)
            {
                // remove item multiple times
                // based on difference of quantities
                RemoveItems(item.Id.ToString(), currentQuantity, newQuantity);
            }
            else if (newQuantity > currentQuantity)
            {
                // add difference of quantities
                AddItems(item, currentQuantity, newQuantity);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row != null && !row.Cells["selectedDataGridViewCheckBoxColumn"].Selected)
            {
                return;
            }

            string itemId = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            string selectItemColumnValue = row.Cells["selectedDataGridViewCheckBoxColumn"].Value.ToString();

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
                int quantity = CreateAnalysisRequestFormUserControl.analysisItemList.Where(it => it.Id == item.Id).ToList().Count;

                it.Quantity = "0";

                List<AnalysisSampleBindingItem> existingItems = CreateAnalysisRequestFormUserControl.analysisItemList
                    .Where(it => it.Id.ToString() != itemId)
                    .ToList();

                CreateAnalysisRequestFormUserControl.analysisItemList.Clear();

                existingItems.ForEach(it =>
                {
                    CreateAnalysisRequestFormUserControl.analysisItemList.Add(it);
                });
            }
            else
            {
                item.Selected = true;
                AnalysisSampleBindingItem it = itemList.First(aI => aI.Id.ToString() == itemId);

                it.Quantity = "1";
                row.Cells["addAnalysisSamplesQuantity"].ReadOnly = false;
                CreateAnalysisRequestFormUserControl.analysisItemList.Add(it);
            }

            dataGridView1.Refresh();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row == null)
            {
                return;
            }

            if (row.Cells[e.ColumnIndex].OwningColumn.Name != "addAnalysisSamplesQuantity")
            {
                return;
            }

            string itemId = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            string selectItemColumnValue = row.Cells["addAnalysisSamplesQuantity"].Value.ToString();

            var item = itemList.FirstOrDefault(it => it.Id.ToString() == itemId);
            int oldQuantity = CreateAnalysisRequestFormUserControl.analysisItemList.Where(it => it.Id.ToString() == itemId).Count();

            try
            {
                int value = int.Parse(selectItemColumnValue);

                if (value <= 0)
                {
                    Utils.Utils.ShowMessageBox(
                        "The value you have entered is invalid. You can only write positive integers.",
                        "Invalid Quantity",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    row.Cells["addAnalysisSamplesQuantity"].Value = oldQuantity;
                    return;
                }

                item.Selected = true;
                dataGridView1.Refresh();
                OnQuantityChanged(item, value);
            } catch (Exception ex)
            {
                row.Cells["addAnalysisSamplesQuantity"].Value = oldQuantity;
                Utils.Utils.ShowMessageBox(
                    "The quantity can only be an integer ",
                    "Quantity Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
