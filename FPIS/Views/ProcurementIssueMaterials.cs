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
    public partial class ProcurementIssueMaterials : UserControl
    {
        private static ProcurementIssueMaterials instance;

        private readonly UserService userService;
        private readonly AnalysisRawMaterialsService analysisService;

        public static BindingList<AnalysisRawMaterialsSampleBindingItem> analysisItemList = new();
        private ProcurementIssueMaterials()
        {
            InitializeComponent();
            dataGridView1.DataSource = analysisItemList;

            AppDbContext context = new();
            analysisService = new(context);
            userService = new(context);
        }
        public static ProcurementIssueMaterials Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProcurementIssueMaterials();
                    return instance;
                }
                return instance;
            }
        }

        private void OpenAddMaterialsControl_Click(object sender, EventArgs e)
        {
            AddRawMaterialsAnalysisSampleForm addRawMaterialsAnalysisSampleForm = new();
            addRawMaterialsAnalysisSampleForm.ShowDialog();
        }

        private void RequestForAnalysisControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (analysisItemList.Count == 0)
                {
                    Utils.Utils.ShowMessageBox(
                        $"Please add a sample for the analysis.",
                        "Invalid Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                    return;
                }

                DialogResult confirmDialogResult = Utils.Utils.ShowMessageBox(
                    "Are you sure you want to create this analysis request?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmDialogResult != DialogResult.Yes)
                {
                    return;
                }
                
                OpenAddMaterialsControl.Enabled = false;
                RequestForAnalysisControl.Enabled = false;

                MaterialProcurementService materialProcuredService = new MaterialProcurementService(new());
                ReleasingService releasingService = new ReleasingService(new());

                foreach (AnalysisRawMaterialsSampleBindingItem analysisItem in analysisItemList)
                {
                    MaterialProcurement materialReceivedToBeReleased = new MaterialProcurement();
                    MaterialProcurement materialProcuredToBeReleased = new MaterialProcurement();
                    Receiving materialReceived = new Receiving();

                    materialReceivedToBeReleased = materialProcuredService.GetMaterialProcuredById(analysisItem.MaterialProcuredId);
                    materialReceived = materialReceivedToBeReleased.Receivings.FirstOrDefault();

                    materialProcuredToBeReleased.Location = materialReceivedToBeReleased.Location;
                    materialProcuredToBeReleased.ProductId = materialReceivedToBeReleased.ProductId;
                    materialProcuredToBeReleased.Remarks = "update";
                    materialProcuredToBeReleased.Type = "Releasing";
                    materialProcuredToBeReleased.UserId = Guid.Parse(Main.LOGGED_USER_ID);
                    Releasing materialToBeReleased = new Releasing();
                    materialToBeReleased.ReceivingId = materialReceived.Id;
                    materialReceivedToBeReleased = materialProcuredService.SaveMaterialProcuredRecord(materialProcuredToBeReleased);
                    materialToBeReleased.MaterialProcurementId = materialReceivedToBeReleased.Id;
                    releasingService.SaveMaterialsToBeReleased(materialToBeReleased);
                }

                UserService userService = new UserService(new());
                Guid userId = Guid.Parse(Main.LOGGED_USER_ID);
                analysisService.CreateSample(
                    userId,
                    userService.GetEmployeeIdByGuid(userId),
                    userService.GetEmployeeIdByGuid(userId),
                    DateOnly.FromDateTime(DateTime.UtcNow.Date),
                    TimeOnly.FromDateTime(DateTime.UtcNow),
                    "Production",
                    analysisItemList.ToList()
                );

                analysisItemList.Clear();

                OpenAddMaterialsControl.Enabled = true;
                RequestForAnalysisControl.Enabled = true;

                Utils.Utils.ShowMessageBox(
                    "Successfully sent analysis request. You can send a new request if you want?",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                Utils.Utils.ShowMessageBox(
                    $"We were unable to create the Analysis Request. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
