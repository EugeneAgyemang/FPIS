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
        private readonly AnalysisRawMaterialItemService analysisItemService;
        private readonly BindingList<AnalysisRawMaterialsSampleBindingItem> itemList = new();

        public AddRawMaterialsAnalysisSampleForm()
        {
            InitializeComponent();
            //Theme.FormInstance = this;
            //Theme.Set(Themes.LIGHT);
            dataGridView1.DataSource = itemList;

            selectedSamples = ProcurementIssueMaterials.analysisItemList.ToArray();
            ProcurementIssueMaterials.analysisItemList.Clear();


            analysisItemService = new(new AppDbContext());
            LoadAnalysisRawMaterials();
        }

        // NOTE: THIS IS WHERE I HAVE REACHED. I REALIZED I NEED TO PULL DATA FROM
        // THE MATERIAL PROCUREMENT AND RECEIVING TABLE TO POPULATE MY GRID. SO THE
        // USER WOULD SELECT THE STOCK THEY WOULD LIKE TO ISSUE. DO NOTE THEY WOULD
        // BE ISSUING FROM THE STOCK RECEIVED. 
        /*
         * CURRENTLY THE AGREED WORKFLOW IS THIS:
         * 1. USER SELECTS THE ITEMS THEY WISH TO ANALYZE
         * 2. USER TRACKS THE STATUS OF THE REQUEST
         * 3. USER IS PROBABLY NOTIFIED OF THE STATUS UPDATE ON THE REQUEST
         * 4. USER SELECTS THE ITEM IN THE GRID THEY WISH TO PROVIDE THE QUANTITY ISSUED
         * 5. USER SAVES AND QUANTITY IS UPDATED
         */
        private void LoadAnalysisRawMaterials()
        {
            List<Product> analysisProducts = analysisItemService.FetchAnalysisProducts();

            foreach (Product ap in analysisProducts)
            {
                MaterialProcurement[] materialsProcured = ap.MaterialProcurements.ToArray();
                foreach (MaterialProcurement materialProcured in materialsProcured)
                {
                    Receiving materialReceived = materialProcured.Receivings.FirstOrDefault();
                    var existingItem = selectedSamples.FirstOrDefault(it => it.MaterialProcuredId == materialProcured.Id);
                    if(materialReceived == null)
                    {
                        continue;
                    }
                    AnalysisRawMaterialsSampleBindingItem newItem = new()
                    {
                        Id = ap.AnalysisProducts.FirstOrDefault().AnalysisItemId,
                        MaterialProcuredId = materialProcured.Id,
                        IdAsStr = Utils.Utils.GetLastCharacters(materialProcured.Id.ToString(), 4),
                        AnalysisStatus = "Pending",
                        Remarks = materialProcured.Remarks,
                        DateAdded = materialProcured.Date,
                        QuantityReceived = materialReceived.Quantity,
                        QuantityLeft = materialReceived.Quantity,
                        Supplier = materialReceived.Supplier,
                        TruckNumber = materialReceived.TruckNumber,
                        Warehouse = materialProcured.Location,
                        Selected = existingItem != null
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
            itemId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


            // only react if the user clicked on the select item column
            if (e.ColumnIndex != 10)
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
