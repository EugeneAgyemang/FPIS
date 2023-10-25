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
                    Models.ProcurementLocation[] procurementLocations = new ProcurementLocationService(new()).GetProcurmentLocation().ToArray();
                    foreach (Models.ProcurementLocation procurementLocation in procurementLocations)
                    {
                        var existingItem = selectedSamples.FirstOrDefault(it => it.ProcurementLocationId == procurementLocation.Id);
                        int quantityIssued = 0;
                        List<IssueLocation> issueLocations = new AppDbContext().IssueLocations.ToList();
                        if (issueLocations != null)
                        {
                            issueLocations.ForEach(item =>
                            {
                                if (item.ProcurementLocationId == procurementLocation.Id)
                                {
                                    quantityIssued += item.Quantity;
                                }
                            });
                        }
                        if (procurementLocation.Quantity <= quantityIssued || procurementLocation.ReceivingId != materialReceived.Id)
                        {
                            continue;
                        }
                        AnalysisRawMaterialsSampleBindingItem newItem = new()
                        {
                            Id = analysisProduct.AnalysisItemId,
                            ProcurementLocationId = procurementLocation.Id,
                            Remarks = materialProcured.Remarks,
                            DateAdded = materialProcured.Date,
                            QuantityLeft = procurementLocation.Quantity - quantityIssued,
                            QuantityReceived = procurementLocation.Quantity,
                            Location = procurementLocation.Location,
                            Lot = procurementLocation.Lot,
                            Supplier = materialReceived.Supplier,
                            TruckNumber = materialReceived.TruckNumber,
                            Selected = existingItem != null,
                            ProductName = analysisProduct.Product.ProductName
                        };

                        itemList.Add(newItem);

                        if (existingItem != null)
                        {
                            ProcurementIssueMaterials.analysisItemList.Add(newItem);
                        }
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

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            selectItemColumnValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            itemId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


            // only react if the user clicked on the select item column
            if (e.ColumnIndex != 7)
            {
                return;
            }

            var item = itemList.FirstOrDefault(it => it.ProcurementLocationId.ToString() == itemId);

            if (item == null)
            {
                return;
            }

            // this is because it shows false before it turns to true
            // and vice-versa
            if (selectItemColumnValue.Equals("True"))
            {
                item.Selected = false;
                AnalysisRawMaterialsSampleBindingItem it = itemList.First(it => it.ProcurementLocationId == item.ProcurementLocationId);
                ProcurementIssueMaterials.analysisItemList.Remove(it);
            }
            else
            {
                item.Selected = true;
                AnalysisRawMaterialsSampleBindingItem it = itemList.First(aI => aI.ProcurementLocationId.ToString() == itemId);
                ProcurementIssueMaterials.analysisItemList.Add(it);
            }
        }
    }
}
