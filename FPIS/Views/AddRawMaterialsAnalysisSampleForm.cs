using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using Moq;
using System.ComponentModel;
using System.Linq;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class AddRawMaterialsAnalysisSampleForm : MaterialForm
    {
        private readonly AnalysisRawMaterialsSampleBindingItem[] selectedSamples;
        private readonly AnalysisItemService analysisItemService;
        private readonly BindingList<AnalysisRawMaterialsSampleBindingItem> itemList = new();

        public AddRawMaterialsAnalysisSampleForm()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            dataGridView1.DataSource = itemList;

            selectedSamples = ProcurementIssueMaterials.analysisItemList.ToArray();
            ProcurementIssueMaterials.analysisItemList.Clear();


            analysisItemService = new(new AppDbContext());
            LoadAnalysisRawMaterials();
        }
        private void LoadAnalysisRawMaterials()
        {
            List<AnalysisProduct> analysisProducts = analysisItemService.FetchAnalysisProducts();

            foreach (AnalysisProduct analysisProduct in analysisProducts)
            {
                MaterialProcurement[] materialsProcured = new MaterialProcurementService(new()).GetMaterialsProcuredForItem(analysisProduct.AnalysisItemId).ToArray();
                foreach (MaterialProcurement materialProcured in materialsProcured)
                {
                    Receiving materialReceived = materialProcured.Receivings.FirstOrDefault();
                    if(materialReceived == null)
                    {
                        continue;
                    }
                    var existingItem = selectedSamples.FirstOrDefault(it => it.MaterialProcuredId == materialProcured.Id);
                    if (materialReceived.Quantity <= 1)
                    {
                        continue;
                    }
                    AnalysisRawMaterialsSampleBindingItem newItem = new()
                    {
                        Id = analysisProduct.AnalysisItemId,
                        MaterialProcuredId = materialProcured.Id,
                        IdAsStr = Utils.Utils.GetLastCharacters(materialProcured.Id.ToString(), 4),
                        AnalysisStatus = "Pending",
                        NetWeight = materialReceived.NetWeight,
                        Remarks = materialProcured.Remarks,
                        DateAdded = materialProcured.Date,
                        QuantityLeft = materialReceived.Quantity,
                        QuantityReceived = materialReceived.Quantity + new ReleasingService(new()).GetQuantityIssuedFromMaterialReceived(materialReceived.Id),
                        Supplier = materialReceived.Supplier,
                        TruckNumber = materialReceived.TruckNumber,
                        Warehouse = materialProcured.Location,
                        Selected = existingItem != null,
                        Lot = materialProcured.Lot
                    };

                    itemList.Add(newItem);

                    if (existingItem != null)
                    {
                        ProcurementIssueMaterials.analysisItemList.Add(newItem);
                    }

                }


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            string selectItemColumnValue, itemId;

            selectItemColumnValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            itemId = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


            // only react if the user clicked on the select item column
            if (e.ColumnIndex != 11)
            {
                return;
            }

            var item = itemList.FirstOrDefault(it => it.MaterialProcuredId.ToString() == itemId);

            if (item == null)
            {
                return;
            }

            // this is because it shows false before it turns to true
            // and vice-versa
            if (selectItemColumnValue.Equals("True"))
            {
                item.Selected = false;
                AnalysisRawMaterialsSampleBindingItem it = itemList.First(it => it.MaterialProcuredId == item.MaterialProcuredId);
                ProcurementIssueMaterials.analysisItemList.Remove(it);
            }
            else
            {
                item.Selected = true;
                AnalysisRawMaterialsSampleBindingItem it = itemList.First(aI => aI.MaterialProcuredId.ToString() == itemId);
                ProcurementIssueMaterials.analysisItemList.Add(it);
            }
        }
    }
}
