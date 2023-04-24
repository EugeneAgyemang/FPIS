using FPIS.Data;
using FPIS.Models;
using FPIS.Services;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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

        public const string DIRECTORY_NAME = "Material Issued";
        public const string EN_ROUTE = "  En Route";
        public const string ANALYZED = "  Analyzed";
        public const string DONE = "  Done";

        public static BindingList<AnalysisRawMaterialsSampleBindingItem> analysisItemList = new();
        private List<FileInfo> samplesRequestedFiles = new List<FileInfo>();
        private ProcurementIssueMaterials()
        {
            InitializeComponent();
            dataGridView1.DataSource = analysisItemList;

            AppDbContext context = new();
            LoadCachedData();
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
                instance.LoadCachedData();
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
            int analysisItemCount = 0;
            string json;
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

                UserService userService = new UserService(new());
                Guid userId = Guid.Parse(Main.LOGGED_USER_ID);
                //Sample sampleCreated = new AnalysisService(new()).CreateSample(
                //    userId,
                //    userService.GetEmployeeIdByGuid(userId),
                //    userService.GetEmployeeIdByGuid(userId),
                //    DateOnly.FromDateTime(DateTime.UtcNow.Date),
                //    TimeOnly.FromDateTime(DateTime.UtcNow),
                //    "Production"
                //);
                //List<SampleDetail> sampleDetails = new SampleDetailsService(new())
                //                                        .SaveRecords
                //                                            (sampleCreated.Id
                //                                            , analysisItemList
                //                                                .ToList());

                List<AnalysisSampleBindingItem> analysisSampleBindingItems = new List<AnalysisSampleBindingItem>();
                foreach (var item in analysisItemList)
                {
                    analysisSampleBindingItems.Add(new AnalysisSampleBindingItem()
                    {
                        Id = item.Id
                    });
                }

                AnalysisService analysis = new AnalysisService(new());
                string empId = new UserService(new()).GetEmployeeIdByGuid(Guid.Parse(Main.LOGGED_USER_ID));
                Sample sampleCreated = analysis.CreateSample(
                    Guid.Parse(Main.LOGGED_USER_ID)
                    , empId
                    , empId
                    , DateOnly.FromDateTime(DateTime.Now)
                    , TimeOnly.FromDateTime(DateTime.Now)
                    , "Production"
                    , analysisSampleBindingItems
                    );



                //MaterialProcurementService materialProcuredService = new MaterialProcurementService(new());
                AnalysisService analysisService = new AnalysisService(new());

                //ReleasingService releasingService = new ReleasingService(new());

                List<SampleDetail> sampleDetails = analysisService.FetchRawMaterialsAnalysis(sampleCreated.Id.ToString()).SampleDetails;
                foreach (SampleDetail sampleDetail in sampleDetails)
                {
                    MaterialProcurement materialReceivedToBeReleased = new MaterialProcurement();
                    MaterialProcurement materialProcuredToBeReleased = new MaterialProcurement();
                    Receiving materialReceived = new Receiving();

                    //materialReceivedToBeReleased = materialProcuredService
                    //                                    .GetMaterialProcuredById
                    //                                        (analysisItemList[analysisItemCount++]
                    //                                            .MaterialProcuredId);

                    //materialReceivedToBeReleased = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.MaterialProcurements.FirstOrDefault(materialProcurement => materialProcurement.Id == analysisItemList[analysisItemCount++].MaterialProcuredId);
                    materialReceivedToBeReleased = sampleDetail
                                                    .AnalysisItem
                                                    .AnalysisProducts
                                                    .FirstOrDefault()
                                                        .Product
                                                        .MaterialProcurements
                                                        .FirstOrDefault
                                                            (materialProcurement => 
                                                                materialProcurement.Id == analysisItemList[analysisItemCount]
                                                                                            .MaterialProcuredId);
                    materialReceived = sampleDetail
                                        .AnalysisItem
                                        .AnalysisProducts
                                        .FirstOrDefault()
                                            .Product
                                            .MaterialProcurements
                                            .FirstOrDefault
                                                (materialProcurement => 
                                                materialProcurement.Id == analysisItemList[analysisItemCount]
                                                                            .MaterialProcuredId)
                                                .Receivings.FirstOrDefault();
                    //materialReceived.Units = materialReceivedToBeReleased.Receivings.FirstOrDefault().Units;
                    //materialReceived.Id = materialReceivedToBeReleased.Receivings.FirstOrDefault().Id;

                    materialProcuredToBeReleased.Location = materialReceivedToBeReleased.Location;
                    materialProcuredToBeReleased.ProductId = materialReceivedToBeReleased.ProductId;
                    materialProcuredToBeReleased.Remarks = materialReceivedToBeReleased.Remarks;
                    materialProcuredToBeReleased.UserId = Guid.Parse(Main.LOGGED_USER_ID);
                    materialProcuredToBeReleased.Lot = materialReceivedToBeReleased.Lot;
                    materialProcuredToBeReleased.Id = materialReceivedToBeReleased.Id;
                    materialReceived.MaterialProcurementId = materialReceivedToBeReleased.Id;
                    materialReceived.MaterialProcurement = materialProcuredToBeReleased;

                    analysisItemCount++;

                    sampleDetail.Sample.SampleDetails = null;
                    sampleDetail.AnalysisItem = null;
                    materialReceived.Releasings = null;
                    int totalNumberOfSamplesRequested = GetLastSchemaId();
                    MaterialIssueSchema materialIssueSchema = new MaterialIssueSchema()
                    {
                        SampleDetail = sampleDetail
                        ,
                        SchemaId = $"{totalNumberOfSamplesRequested}"
                        ,
                        MaterialToBeIssued = materialReceived
                        ,
                        Status = EN_ROUTE
                    };
                    json = JsonParser.Stringify<MaterialIssueSchema>(materialIssueSchema);
                    JsonParser.Write(json, Path.Combine(DIRECTORY_NAME
                                                            , $"material-issue" +
                                                            $"-{sampleCreated.Date.Month}" +
                                                            $"-{sampleCreated.Date.Day}" +
                                                            $"-{sampleCreated.Time.Hour}" +
                                                            $"-{sampleCreated.Time.Minute}" +
                                                            $"-{sampleCreated.Time.Second}" +
                                                            $"-{materialIssueSchema.SchemaId}" +
                                                            $".json"));
                    //break;
                    SamplesRequestedControl.Items.Add(materialIssueSchema);
                }

                analysisItemList.Clear();

                OpenAddMaterialsControl.Enabled = true;
                RequestForAnalysisControl.Enabled = true;

                Utils.Utils.ShowMessageBox(
                    "Successfully sent analysis request. You can send a new request if you want?",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                samplesRequestedFiles = GetSampleFilesForCurrentUser();
                LoadCachedData();
            }
            catch (Exception)
            {
                Utils.Utils.ShowMessageBox(
                    $"We were unable to create the Analysis Request. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private int GetLastSchemaId()
        {
            string json;
            string schemaFileName = "schema-issued-id.json";
            if (!(JsonParser.DoesFileExists(Path.Combine(DIRECTORY_NAME, schemaFileName))))
            {
                json = JsonParser.Stringify<string>("{schema-id:1}");
                JsonParser.Write(json, Path.Combine(DIRECTORY_NAME, schemaFileName));

            }
            json = JsonParser.Read(Path.Combine(DIRECTORY_NAME, schemaFileName));
            string schemaIdAsStr = (string)JsonParser.Parse<string>(json);
            int lastSchemaId = int.Parse(schemaIdAsStr.Split(":")[1].Split("}")[0]);
            json = JsonParser.Stringify<string>($"{{schema-id:{lastSchemaId + 1}}}");
            JsonParser.Write(json, Path.Combine(DIRECTORY_NAME, schemaFileName));

            return lastSchemaId;

        }
        private void SamplesRequestedControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string json;
            string sampleSelected = SamplesRequestedControl.Text;
            if (sampleSelected == string.Empty)
            {
                return;
            }
            string schemaId = sampleSelected.Split("#")[1].Split(" ")[0];
            List<FileInfo> files = GetSampleFilesForCurrentUser();
            MaterialIssueSchema materialIssueSchema = null;
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                materialIssueSchema = (MaterialIssueSchema)JsonParser.Parse<MaterialIssueSchema>(json);
                if (materialIssueSchema.SchemaId == schemaId)
                {
                    break;
                }
            }
            if (materialIssueSchema == null)
            {
                return;
            }
            if (materialIssueSchema.Status == DONE)
            {
                IssueSectionControl.Visible = true;
            }
            else
            {
                IssueSectionControl.Visible = false;
            }
            string productIssued = new ProductService(new())
                                        .GetProductById(materialIssueSchema
                                            .MaterialToBeIssued
                                            .MaterialProcurement
                                            .ProductId)
                                        .ToString();
            SampleRequestedDetailsControl.Text = $"{((materialIssueSchema.Status == ProcurementIssueMaterials.DONE) ? "Viewing r" : "R")}equest for" +
                //$"***delete this whole line - {materialIssueSchema.MaterialToBeIssued.MaterialProcurementId}" +
                $" {productIssued} from {materialIssueSchema.MaterialToBeIssued.MaterialProcurement.Location} lot {materialIssueSchema.MaterialToBeIssued.MaterialProcurement.Lot}" +
                $" with request #️{materialIssueSchema.SchemaId}" +
                $" made on {materialIssueSchema.SampleDetail.Sample.Date.ToLongDateString()}" +
                $" at {materialIssueSchema.SampleDetail.Sample.Time.ToShortTimeString()}" +
                $" - Status: ({materialIssueSchema.Status.ToUpper().Trim()})";
            NoteControl.Text = $"You can only issue up to {(new AppDbContext().Receivings.FirstOrDefault(receiving => receiving.Id == materialIssueSchema.MaterialToBeIssued.Id).Quantity) - 1} " +
                $"{materialIssueSchema.MaterialToBeIssued.Units} of {productIssued}!\n\n" +
                $"Here's some feedback the last time {productIssued} was received:\n" +
                $"\"{materialIssueSchema.MaterialToBeIssued.MaterialProcurement.Remarks}\" - " +
                $"{new UserService(new()).GetFullName(materialIssueSchema.SampleDetail.Sample.UserId)}";
        }
        private List<FileInfo> GetSampleFilesForCurrentUser()
        {
            string json;
            JsonParser.CreateDirectory(DIRECTORY_NAME);
            FileInfo[] allFiles = JsonParser.GetFiles(Path.Combine(DIRECTORY_NAME));
            List<FileInfo> files = new List<FileInfo>();
            foreach (FileInfo file in allFiles)
            {
                if (file.Name.StartsWith("schema"))
                {
                    continue;
                }
                json = JsonParser.Read(file.FullName);
                MaterialIssueSchema cachedData = (MaterialIssueSchema)JsonParser.Parse<MaterialIssueSchema>(json);
                if (cachedData.SampleDetail.Sample.UserId == Guid.Parse(Main.LOGGED_USER_ID))
                {
                    files.Add(file);
                }
            }
            return files;
        }
        private void LoadCachedData()
        {
            string json;
            ResetFields();
            FileInfo[] files = GetSampleFilesForCurrentUser().ToArray();
            int cachedRequests = files.Length;
            if (cachedRequests == 0)
            {
                return;
            }
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                MaterialIssueSchema materialIssueSchema = (MaterialIssueSchema)JsonParser.Parse<MaterialIssueSchema>(json);
                SamplesRequestedControl.Items.Add(materialIssueSchema);
            }
        }
        private void ResetFields()
        {
            SampleRequestedDetailsControl.Text =
                IssueQuantityControl.Text =
                SamplesRequestedControl.Text =
                RemarksCaptionControl.Text =
                NoteControl.Text = string.Empty;
            SamplesRequestedControl.SelectedIndex = -1;
            SamplesRequestedControl.Items.Clear();
            IssueSectionControl.Visible = false;
        }
        private void IssueMaterialsControl_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;
            shouldSave = PerformValidations();
            if (!shouldSave)
            {
                return;
            }
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox($"{((RemarksControl.Text == string.Empty) ? "Looks like you forgot to provide a remark 😟\n\n" : string.Empty)}" +
                                                    $"Do you wish to proceed{((RemarksControl.Text == string.Empty) ? " anyways" : string.Empty)}" +
                                                    $"{((RemarksControl.Text == string.Empty) ? " without adding any remarks?" : "?")}"
                                                    , "Continue"
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question);
            if (userReponseToProceed != DialogResult.Yes)
            {
                return;
            }
            shouldSave = CheckIssueQuantity();
            if (!shouldSave)
            {
                IssueQuantityControl.Focus();
                return;
            }
            MaterialProcurement materialProcured = SaveMaterialProcuredRecord();
            if (materialProcured != null)
            {
                DeleteCachedFile();
                LoadCachedData();
                Utils.Utils.ShowMessageBox("Raw material issued has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CheckIssueQuantity()
        {
            int issueQuantity;
            int.TryParse(IssueQuantityControl.Text, out issueQuantity);
            MaterialIssueSchema materialIssueSchema = GetMaterialIssuedSchema();
            int actualQuantity = (new AppDbContext().Receivings.FirstOrDefault(receiving => receiving.Id == materialIssueSchema.MaterialToBeIssued.Id).Quantity);
            if (issueQuantity >= actualQuantity)
            {
                Utils.Utils.ShowMessageBox("There isn't enough stock available to be issued!", "Issue Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private MaterialProcurement SaveMaterialProcuredRecord()
        {
            MaterialProcurement materialProcurement = GetMaterialToBeProcured();
            MaterialProcurementService materialProcurementService = new MaterialProcurementService(new());
            MaterialProcurement materialProcured = materialProcurementService.SaveMaterialProcuredRecord(materialProcurement);
            SaveMaterialReleasedRecord(materialProcured.Id, GetMaterialIssuedSchema().MaterialToBeIssued.Id);
            return materialProcured;
        }
        private void SaveMaterialReleasedRecord(Guid materialProcurementId, Guid materialReceivedId)
        {
            Releasing materialReleaseRecord = GetMaterialToBeReleased(materialProcurementId);
            ReleasingService releasingService = new ReleasingService(new());
            releasingService.SaveMaterialToBeReleased(materialReleaseRecord, materialReceivedId);
            UpdateMaterialQuantity(materialReleaseRecord.Quantity);
        }
        private MaterialProcurement GetMaterialToBeProcured()
        {
            MaterialIssueSchema materialIssueSchema = GetMaterialIssuedSchema();
            return new MaterialProcurement()
            {
                Date = DateOnly.FromDateTime(DateTime.Now)
                ,
                UserId = Guid.Parse(Main.LOGGED_USER_ID)
                ,
                Location = materialIssueSchema.MaterialToBeIssued.MaterialProcurement.Location
                ,
                Lot = materialIssueSchema.MaterialToBeIssued.MaterialProcurement.Lot
                ,
                ProductId = materialIssueSchema.MaterialToBeIssued.MaterialProcurement.ProductId
                ,
                Type = "Releasing"
                ,
                Remarks = RemarksControl.Text
            };
        }
        private Releasing GetMaterialToBeReleased(Guid materialProcurementId)
        {
            int quantity;
            int.TryParse(IssueQuantityControl.Text, out quantity);
            return new Releasing()
            {
                MaterialProcurementId = materialProcurementId
                ,
                Quantity = quantity
            };
        }
        private Receiving UpdateMaterialQuantity(int quantityToIssue)
        {
            MaterialIssueSchema materialIssueSchema = GetMaterialIssuedSchema();
            int quantityAvailable = (new AppDbContext().Receivings.FirstOrDefault(receiving => receiving.Id == materialIssueSchema.MaterialToBeIssued.Id).Quantity);
            quantityAvailable -= quantityToIssue;
            int updatedQuantity = quantityAvailable;
            ReceivingService receivingService = new ReceivingService(new());
            return receivingService.UpdateReceivedQuantity(materialIssueSchema.MaterialToBeIssued.Id
                                                        , updatedQuantity);
        }
        private MaterialIssueSchema GetMaterialIssuedSchema()
        {
            string json;
            List<FileInfo> files = GetSampleFilesForCurrentUser();
            MaterialIssueSchema materialIssueSchema = null;
            string schemaId = SamplesRequestedControl.Text.Split("#")[1].Split(" ")[0];
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                materialIssueSchema = (MaterialIssueSchema)JsonParser
                                                            .Parse<MaterialIssueSchema>
                                                                (json);
                if (schemaId == materialIssueSchema.SchemaId &&
                    materialIssueSchema.MaterialToBeIssued.MaterialProcurement.UserId
                    == Guid.Parse(Main.LOGGED_USER_ID)
                    && materialIssueSchema.Status.ToLower().Trim() == "done")
                {
                    break;
                }
            }
            return materialIssueSchema;
        }
        private bool PerformValidations()
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            ValidateFields(IssueQuantityControl.Text.Trim(), ref shouldSave);

            return shouldSave;
        }
        public void ValidateFields(string quantity, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateQuantity(quantity, ref shouldSave, ref isErrorMessageDisplayed);
        }
        public void ValidateQuantity(string quantity, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (quantity.Length == 0)
            {
                DisplayErrorMessage(QuantityErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the quantity you want to issue");
                return;
            }
        }
        private void DisplayErrorMessage(Label errorCaption, ref bool shouldSave, ref bool isErrorMessageDisplayed, string message)
        {
            shouldSave = false;
            if (!isErrorMessageDisplayed)
            {
                isErrorMessageDisplayed = true;
                Utils.Utils.ShowMessageBox("An error occuured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            errorCaption.Text = message;
        }
        public void ResetErrorCaptions()
        {
            QuantityErrorCaption.Text = string.Empty;
        }

        private void IssueQuantityControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void RemarksControl_KeyUp(object sender, KeyEventArgs e)
        {
            string remarks = RemarksControl.Text;
            int charactersTyped = LiveCharacterCount(500, remarks);
            RemarksCaptionControl.Text = $"Remarks ({charactersTyped} characters)";
        }
        public static int LiveCharacterCount(int maxLength, string contents)
        {
            int length = contents.Length;
            int charactersTyped = maxLength - length;
            return charactersTyped;
        }
        private void DeleteCachedFile()
        {
            string json;
            FileInfo[] files = GetSampleFilesForCurrentUser().ToArray();
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                MaterialProcurementSchema materialIssueSchema = (MaterialProcurementSchema)JsonParser
                                                                        .Parse<MaterialProcurementSchema>
                                                                        (json);
                string schemaId = SamplesRequestedControl.Text.Split("#")[1].Split(" ")[0];
                if (materialIssueSchema.Status.ToLower().Trim() == "done"
                    && schemaId == materialIssueSchema.SchemaId
                    && materialIssueSchema.SampleDetail.Sample.UserId
                        == Guid.Parse(Main.LOGGED_USER_ID))
                {
                    JsonParser.DeleteFile(Path.Combine(DIRECTORY_NAME, file.Name));
                    LoadCachedData();
                    ResetFields();
                    ResetErrorCaptions();
                    return;
                }
            }
        }
    }
}