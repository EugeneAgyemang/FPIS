using FPIS.Data;
using FPIS.Migrations;
using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
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
        public const string ISSUE = "Issue";

        public static BindingList<AnalysisRawMaterialsSampleBindingItem> analysisItemList = new();
        private List<FileInfo> samplesRequestedFiles = new List<FileInfo>();
        private List<string> batches = new List<string>();
        private static int batch = 0;
        private string activeBatch = "";
        private static Dictionary<string, IssueLocation> issueLocations = new Dictionary<string, IssueLocation>();
        List<Models.ProcurementLocation> procurementLocations = null;
        public ProcurementIssueMaterials()
        {
            InitializeComponent();
            dataGridView1.DataSource = analysisItemList;
            AppDbContext context = new();
            LoadCachedData();
        }

        private void OpenAddMaterialsControl_Click(object sender, EventArgs e)
        {
            AddRawMaterialsAnalysisSampleForm addRawMaterialsAnalysisSampleForm = new();
            addRawMaterialsAnalysisSampleForm.ShowDialog();
        }

        private void RequestForAnalysisControl_Click(object sender, EventArgs e)
        {
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
                    "Are you sure you want to send these samples for analysis?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmDialogResult != DialogResult.Yes)
                {
                    return;
                }
                batch++;
                OpenAddMaterialsControl.Enabled = false;
                RequestForAnalysisControl.Enabled = false;
                UserService userService = new UserService(new());
                Guid userId = Guid.Parse(Main.LOGGED_USER_ID);
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
                AnalysisService analysisService = new AnalysisService(new());

                List<SampleDetail> sampleDetails = analysisService
                                                    .FetchRawMaterialsReceivedAnalysis
                                                    (sampleCreated.Id.ToString())
                                                    .SampleDetails;
                foreach (SampleDetail sampleDetail in sampleDetails)
                {
                    MaterialProcurement materialReceivedToBeReleased = null;
                    MaterialProcurement materialProcuredToBeReleased = new MaterialProcurement();
                    Receiving storedRecord = null;
                    Receiving materialReceived = null;
                    List<Models.ProcurementLocation> procurementLocations = new List<Models.ProcurementLocation>();
                    Guid procurementLocationId = Guid.NewGuid();

                    procurementLocationId = FindProcurementLocationId();
                    int x = 0;
                    materialReceivedToBeReleased = new AppDbContext()
                                                    .ProcurementLocations
                                                    .Include(record =>
                                                        record.Receiving)
                                                    .ThenInclude(record =>
                                                        record.MaterialProcurement)
                                                    .FirstOrDefault(record =>
                                                        record.Id == procurementLocationId)
                                                    .Receiving
                                                    .MaterialProcurement;



                                                    //.MaterialProcurements
                                                    //.FirstOrDefault()
                                                    //.Receivings
                                                    //.FirstOrDefault()
                                                    //.ProcurementLocations
                                                    //.FirstOrDefault(record =>
                                                    //    record.Id == procurementLocationId)
                                                    //.Receiving
                                                    //.MaterialProcurement;

                    //materialReceivedToBeReleased = sampleDetail
                    //                                .AnalysisItem
                    //                                .AnalysisProducts
                    //                                .FirstOrDefault()
                    //                                .Product
                    //                                .MaterialProcurements
                    //                                .FirstOrDefault
                    //                                    (record =>
                    //                                    record
                    //                                    .Receivings
                    //                                    .FirstOrDefault()
                    //                                    .ProcurementLocations
                    //                                    .FirstOrDefault
                    //                                        (pl =>
                    //                                        pl.Id == procurementLocationId)
                    //                                    != null);
                    storedRecord = materialReceivedToBeReleased.Receivings.FirstOrDefault();
                    materialReceived = new Receiving()
                    {
                        Id = storedRecord.Id,
                        GrossWeight = storedRecord.GrossWeight,
                        NetWeight = storedRecord.NetWeight,
                        City = storedRecord.City,
                        Country = storedRecord.Country,
                        Quantity = storedRecord.Quantity,
                        Supplier = storedRecord.Supplier,
                        TruckNumber = storedRecord.TruckNumber,
                        Units = storedRecord.Units
                    };
                    materialProcuredToBeReleased.ProductId = materialReceivedToBeReleased.ProductId;
                    materialProcuredToBeReleased.UserId = Guid.Parse(Main.LOGGED_USER_ID);
                    materialProcuredToBeReleased.Id = materialReceivedToBeReleased.Id;
                    materialProcuredToBeReleased.Remarks = materialReceivedToBeReleased.Remarks;
                    materialReceived.MaterialProcurementId = materialReceivedToBeReleased.Id;
                    materialReceived.MaterialProcurement = materialProcuredToBeReleased;
                    sampleDetail.Sample.SampleDetails = null;
                    sampleDetail.AnalysisItem = null;
                    foreach (Models.ProcurementLocation item in storedRecord.ProcurementLocations)
                    {
                        if (item.Id == procurementLocationId)
                        {
                            procurementLocations.Add(new Models.ProcurementLocation()
                            {
                                Id = item.Id,
                                Location = item.Location,
                                Lot = item.Lot,
                                Quantity = item.Quantity,
                                ReceivingId = item.ReceivingId,
                                ApproxWeight = item.ApproxWeight
                            });
                            break;
                        }
                    }
                    materialReceived.ProcurementLocations = procurementLocations;
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
                        ,
                        Weight = materialReceived.NetWeight
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
                                                            $"-batch{batch}" +
                                                            $".json"));
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

        private Guid FindProcurementLocationId()
        {
            Guid procurementLocationId = Guid.NewGuid();
            foreach (Models.ProcurementLocation item in new AppDbContext().ProcurementLocations)
            {
                bool isFound = false;
                Guid currentId = item.Id;
                foreach (AnalysisRawMaterialsSampleBindingItem listItem in analysisItemList)
                {
                    Guid listItemId = listItem.ProcurementLocationId;
                    if (listItemId != currentId)
                    {
                        continue;
                    }
                    isFound = true;
                    procurementLocationId = listItemId;
                    analysisItemList.Remove(listItem);
                    break;
                }
                if (isFound)
                {
                    break;
                }
            }
            return procurementLocationId;
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
            string json, batch = "";
            string sampleSelected = SamplesRequestedControl.Text;
            int batchesLeft = 0;

            if (sampleSelected == string.Empty)
            {
                return;
            }
            IssueQuantityControl.Text = WeightControl.Text = RemarksControl.Text = "";
            RemarksCaptionControl.Text = "Remarks (500 characters)";
            string schemaId = sampleSelected.Split("#")[1].Split(" ")[0];
            List<FileInfo> files = GetSampleFilesForCurrentUser();
            MaterialIssueSchema materialIssueSchema = null;
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                materialIssueSchema = (MaterialIssueSchema)JsonParser.Parse<MaterialIssueSchema>(json);
                if (materialIssueSchema.SchemaId == schemaId)
                {
                    activeBatch = batch = file.Name.Split("batch")[1].Split(".")[0];
                    break;
                }
            }
            if (materialIssueSchema == null)
            {
                return;
            }
            if (materialIssueSchema.Status == DONE)
            {
                WeightControl.Enabled =
                        RemarksControl.Enabled = IsLastItemInBatch(batch, ref batchesLeft);
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
                $" {productIssued}" +
                $" with request #️{materialIssueSchema.SchemaId}" +
                $" made on {materialIssueSchema.SampleDetail.Sample.Date.ToLongDateString()}" +
                $" at {materialIssueSchema.SampleDetail.Sample.Time.ToShortTimeString()}" +
                $" - Status: ({materialIssueSchema.Status.ToUpper().Trim()})";
            if (materialIssueSchema.Status != DONE && materialIssueSchema.Status != ISSUE)
            {
                return;
            }
            Models.ProcurementLocation procurementLocation = materialIssueSchema.MaterialToBeIssued.ProcurementLocations.FirstOrDefault();
            NoteControl.Text = $"You can only issue up to {procurementLocation.Quantity} " +
                $"{materialIssueSchema.MaterialToBeIssued.Units} of {productIssued}!\n\n" +
                $"Source: Warehouse {procurementLocation.Location}, lot {procurementLocation.Lot}\n\n" +
                $"{((materialIssueSchema.MaterialToBeIssued.MaterialProcurement.Remarks != string.Empty) ? $"Here's some feedback the last time {productIssued} was received:\n{materialIssueSchema.MaterialToBeIssued.MaterialProcurement.Remarks} - " : "No remarks given by ")}" +
                $"{new UserService(new()).GetFullName(materialIssueSchema.SampleDetail.Sample.UserId)}";
            PreviousNetWeightControl.Hint = $"Net weight when {Utils.Utils.TruncateLengthyText(productIssued, 10)} was received";
            helper.SetToolTip(PreviousNetWeightControl, PreviousNetWeightControl.Hint);

            PreviousNetWeightControl.Text = $"{procurementLocation.ApproxWeight}kg for {TotalQuantityReceived(procurementLocation)} {materialIssueSchema.MaterialToBeIssued.Units}";
            BatchDetailsCaptionControl.Text
                = $"{(CountItemsInBatch(activeBatch) == 1 ? "The only" : CountItemsInBatch(activeBatch))} material{(CountItemsInBatch(activeBatch) == 1 ? "" : "s")} left to be issued";
        }

        private int TotalQuantityReceived(Models.ProcurementLocation procurementLocation)
        {
            int quantity = 0;

            quantity += procurementLocation.Quantity;
            new AppDbContext().IssueLocations.ToList().ForEach(record =>
            {
                if (record.ProcurementLocationId == procurementLocation.Id)
                {
                    quantity += record.Quantity;
                }
            });

            return quantity;
        }

        private int CountItemsInBatch(string batch)
        {
            int batchCount = 0;

            batches.ForEach(record =>
                batchCount += ($"{record}" == batch ? 1 : 0)
            );

            return batchCount;
        }

        private bool IsLastItemInBatch(string batch, ref int batchesLeft)
        {
            int batchCount = 0;

            batchCount = CountItemsInBatch(batch);
            batchesLeft = batchCount - 1;
            return batchCount == 1;
        }

        private float CalculateNetWeight(string batch)
        {
            string current_batch = "", json = "", schemaId = "";
            List<FileInfo> files = GetSampleFilesForCurrentUser();
            MaterialIssueSchema materialIssueSchema = null;
            float netWeight = 0, approxWeight = 0;

            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                materialIssueSchema = (MaterialIssueSchema)JsonParser.Parse<MaterialIssueSchema>(json);
                current_batch = file.Name.Split("batch")[1].Split(".")[0];
                if (batch == current_batch)
                {
                    float.TryParse(materialIssueSchema
                                    .MaterialToBeIssued
                                    .ProcurementLocations
                                    .FirstOrDefault()
                                    .ApproxWeight, out approxWeight);
                    netWeight += approxWeight;
                }
            }
            return netWeight;
        }

        private List<FileInfo> GetSampleFilesForCurrentUser()
        {
            string json;
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
            string json, batch = "";
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
                batch = file.Name.Split("batch")[1].Split(".")[0];
                if (materialIssueSchema.Status != ISSUE)
                {
                    SamplesRequestedControl.Items.Add(materialIssueSchema);
                    batches.Add(batch);
                }
            }
        }

        private void ResetFields()
        {
            SampleRequestedDetailsControl.Text =
                IssueQuantityControl.Text =
                SamplesRequestedControl.Text =
                WeightRemarkControl.Text =
                PreviousNetWeightControl.Text =
                WeightControl.Text =
                NoteControl.Text = string.Empty;
            SamplesRequestedControl.SelectedIndex = -1;
            SamplesRequestedControl.Items.Clear();
            WeightControl.Enabled =
                RemarksControl.Enabled = true;
            IssueSectionControl.Visible = false;
            RemarksCaptionControl.Text = "Remarks (500 characters)";
        }

        private void IssueMaterialsControl_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;

            shouldSave = CheckIssueQuantity();
            if (!shouldSave)
            {
                IssueQuantityControl.Focus();
                return;
            }
            shouldSave = PerformValidations();
            if (!shouldSave)
            {
                return;
            }
            IssueLocation issueLocation = AddIssueLocation();
            if (issueLocation == null)
            {
                MaterialProcurement materialProcured = SaveMaterialProcuredRecord();
                if (materialProcured != null)
                {
                    UpdateBatchDetails();
                    DeleteCachedFile();
                    LoadCachedData();
                    Utils.Utils.ShowMessageBox("Raw material issued has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateBatchDetails()
        {
            issueLocations.ToList().ForEach(record =>
            {
                if (activeBatch == record.Key.Split("batch")[1].Split(".")[0])
                {
                    issueLocations.Remove(record.Key);
                }
            });
            batches.Clear();
        }

        private IssueLocation AddIssueLocation()
        {
            int quantity = 0, batchesLeft = -1;
            string filename = "", json = "", schemaId = "", message = "";
            IssueLocation issueLocation = null;
            MaterialIssueSchema materialIssueSchema = null;

            if (!IsLastItemInBatch(activeBatch, ref batchesLeft) || batchesLeft == 0)
            {
                message = "Do you wish to save the details provided?";
                if (batchesLeft == 0)
                {
                    message = $"{((RemarksControl.Text == string.Empty) ? "Looks like you forgot to provide a remark 😟\n\n" : string.Empty)}" +
                                                    $"Do you wish to proceed{((RemarksControl.Text == string.Empty) ? " anyways" : string.Empty)}" +
                                                    $"{((RemarksControl.Text == string.Empty) ? " without adding any remarks?" : "?")}";
                }
                DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox(message
                                                    , "Continue"
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question);
                if (userReponseToProceed != DialogResult.Yes)
                {
                    return new IssueLocation() { };
                }
                int.TryParse(IssueQuantityControl.Text, out quantity);
                List<FileInfo> files = GetSampleFilesForCurrentUser();
                schemaId = SamplesRequestedControl.Text.Split("#")[1].Split(" ")[0];
                foreach (FileInfo file in files)
                {
                    json = JsonParser.Read(file.FullName);
                    materialIssueSchema = (MaterialIssueSchema)JsonParser.Parse<MaterialIssueSchema>(json);
                    if (materialIssueSchema.SchemaId == schemaId)
                    {
                        filename = file.Name;
                        materialIssueSchema.Status = ISSUE;
                        JsonParser.Write(JsonParser.Stringify<MaterialIssueSchema>(materialIssueSchema), file.FullName);
                        break;
                    }
                }
                issueLocation = new IssueLocation()
                {
                    ProcurementLocationId = materialIssueSchema
                                                    .MaterialToBeIssued
                                                    .ProcurementLocations
                                                    .FirstOrDefault()
                                                    .Id,
                    Quantity = quantity,
                    ApproxWeight = materialIssueSchema
                                                    .MaterialToBeIssued
                                                    .ProcurementLocations
                                                    .FirstOrDefault()
                                                    .ApproxWeight
                };
                issueLocations.Add(filename,
                    issueLocation);
                batches.Remove(activeBatch);
                IssueQuantityControl.Text =
                    SampleRequestedDetailsControl.Text = "";
                IssueSectionControl.Visible = false;
                if (batchesLeft == 0)
                {
                    issueLocation = null;
                }
                else
                {
                    SamplesRequestedControl.Items.Remove(SamplesRequestedControl.SelectedItem);
                }
            }
            return issueLocation;
        }

        private void ApproxWeightsCalculator()
        {
            float approxWeightPerUnit = 0;

            approxWeightPerUnit = (float)Math.Round(ApproxWeightPerUnitCalculator(), 2);
            issueLocations.ToList().ForEach(record =>
            {
                if (activeBatch == record.Key.Split("batch")[1].Split(".")[0])
                    record.Value.ApproxWeight = $"{approxWeightPerUnit * record.Value.Quantity}";
            });
        }

        private float ApproxWeightPerUnitCalculator()
        {
            float approxWeights = 0;
            float netWeight = 0;
            int overallQuantity = 0;

            float.TryParse(WeightControl.Text, out netWeight);
            issueLocations.ToList().ForEach(record =>
            {
                if (activeBatch == record.Key.Split("batch")[1].Split(".")[0])
                    overallQuantity += record.Value.Quantity;
            });
            approxWeights = netWeight / overallQuantity;

            return approxWeights;
        }

        private bool CheckIssueQuantity()
        {
            int issueQuantity;
            int.TryParse(IssueQuantityControl.Text, out issueQuantity);
            MaterialIssueSchema materialIssueSchema = GetMaterialIssuedSchema();
            Receiving receiving = materialIssueSchema.MaterialToBeIssued;
            int actualQuantity = new AppDbContext()
                                    .ProcurementLocations
                                    .FirstOrDefault
                                    (record =>
                                        record.Location == materialIssueSchema
                                                        .MaterialToBeIssued
                                                        .ProcurementLocations
                                                        .FirstOrDefault()
                                                        .Location
                                    && record.Lot == materialIssueSchema
                                                        .MaterialToBeIssued
                                                        .ProcurementLocations
                                                        .FirstOrDefault()
                                                        .Lot).Quantity;
            if (issueQuantity > actualQuantity)
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
            materialReleaseRecord = releasingService.SaveMaterialToBeReleased(materialReleaseRecord);
            SaveIssueLocations(materialReleaseRecord.Id);
        }

        private int SaveIssueLocations(Guid releasingId)
        {
            int recordsAdded = 0;
            List<IssueLocation> records = new List<IssueLocation>();
            IssueLocation firstRecord = null;

            ApproxWeightsCalculator();
            issueLocations.ToList().ForEach(issueLocation =>
            {
                if (activeBatch == issueLocation.Key.Split("batch")[1].Split(".")[0])
                    records.Add(issueLocation.Value);
            });
            records.ForEach(record =>
            record.ReleasingId = releasingId);
            firstRecord = new IssueLocationService(new()).SaveRecords(records);
            if (firstRecord != null)
            {
                recordsAdded = records.Count;
            }
            UpdateProcurementLocations();
            return recordsAdded;
        }

        private Models.ProcurementLocation UpdateProcurementLocations()
        {
            List<IssueLocation> records = new List<IssueLocation>();

            issueLocations.ToList().ForEach(issueLocation =>
            {
                if (activeBatch == issueLocation.Key.Split("batch")[1].Split(".")[0])
                    records.Add(issueLocation.Value);
            });
            return new ProcurementLocationService(new()).UpdateQuantity(records)
                        .FirstOrDefault();
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

            quantity = CalculateReleaseQuantity();
            return new Releasing()
            {
                MaterialProcurementId = materialProcurementId,
                Quantity = quantity,
                Weight = WeightControl.Text
            };
        }

        private int CalculateReleaseQuantity()
        {
            int quantity = 0;

            issueLocations.ToList().ForEach(issueLocation =>
            {
                quantity += (activeBatch == issueLocation.Key.Split("batch")[1].Split(".")[0]
                                ? issueLocation.Value.Quantity : 0);
            });

            return quantity;
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
                    materialIssueSchema.Status.ToLower().Trim() == "issue")
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
            ValidateFields(IssueQuantityControl.Text.Trim(), WeightControl.Text.Trim(), ref shouldSave);

            return shouldSave;
        }

        public void ValidateFields(string quantity, string weight, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            int batchesLeft = 0;

            ValidateQuantity(quantity, ref shouldSave, ref isErrorMessageDisplayed);
            if (IsLastItemInBatch(activeBatch, ref batchesLeft))
            {
                ValidateWeight(weight, ref shouldSave, ref isErrorMessageDisplayed);
            }
        }

        public void ValidateQuantity(string quantity, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (quantity.Length == 0)
            {
                DisplayErrorMessage(QuantityErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the quantity you want to issue");
                return;
            }
        }

        public void ValidateWeight(string weight, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (weight.Length == 0)
            {
                DisplayErrorMessage(WeightErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the weight of the raw material to be issued");
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
            QuantityErrorCaption.Text =
            WeightErrorControl.Text = string.Empty;
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
                if (materialIssueSchema.Status.ToLower().Trim() == "issue")
                {
                    JsonParser.DeleteFile(Path.Combine(DIRECTORY_NAME, file.Name));
                }
            }
            ResetFields();
            ResetErrorCaptions();
        }

        private void WeightControl_TextChanged(object sender, EventArgs e)
        {
            // TODO: DELETE THIS ENTIRE BLOCK
            if (WeightControl.Text.Trim().Length == 0)
            {
                WeightRemarkControl.Text = string.Empty;
                return;
            }
            float newWeight;
            float previousWeight = 0;
            float approxWeightPerUnit = 0, prevApproxWeightPerUnit = 0;
            int quantity = 0, prevQuantity = 0;

            if (procurementLocations == null)
            {
                procurementLocations = new AppDbContext().ProcurementLocations.ToList();
            }
            float.TryParse(((MaterialTextBox)sender).Text, out newWeight);

            //ApproxWeightsCalculator();
            issueLocations.ToList().ForEach(record =>
            {
                if (record.Key.Split("batch")[1].Split(".")[0] == activeBatch)
                {
                    quantity += record.Value.Quantity;
                    procurementLocations.ForEach(procurementLocation =>
                    {
                        if (procurementLocation.Id == record.Value.ProcurementLocationId)
                        {
                            previousWeight += float.Parse(procurementLocation.ApproxWeight);
                            prevQuantity += procurementLocation.Quantity;
                        }
                    });
                }
            });
            Models.ProcurementLocation procurementLocation = GetProcurementDetails();
            prevQuantity += procurementLocation.Quantity;
            previousWeight += float.Parse(procurementLocation.ApproxWeight);
            quantity += int.Parse(IssueQuantityControl.Text);
            //prevApproxWeightPerUnit = previousWeight / float.Parse(PreviousNetWeightControl.Text.Split(" ")[2]);
            prevApproxWeightPerUnit = previousWeight / prevQuantity;
            approxWeightPerUnit = newWeight / quantity;

            if (approxWeightPerUnit == prevApproxWeightPerUnit)
            {
                WeightRemarkControl.Text = "The weight remains the same!";
            }
            else if (approxWeightPerUnit > prevApproxWeightPerUnit)
            {
                if ((prevApproxWeightPerUnit + 50) >= approxWeightPerUnit)
                {
                    WeightRemarkControl.Text = "The current weight is slighly higher than when it was received";
                }
                else if ((prevApproxWeightPerUnit + 300) >= approxWeightPerUnit)
                {
                    WeightRemarkControl.Text = "The current weight is mildly higher than when it was received";
                }
                else
                {
                    WeightRemarkControl.Text = "The current weight is drastically higher than when it was received";
                }
            }
            else
            {
                if ((prevApproxWeightPerUnit - 50) <= approxWeightPerUnit)
                {
                    WeightRemarkControl.Text = "The current weight is slighly lower than when it was received";
                }
                else if ((prevApproxWeightPerUnit - 300) <= approxWeightPerUnit)
                {
                    WeightRemarkControl.Text = "The current weight is mildly lower than when it was received";
                }
                else
                {
                    WeightRemarkControl.Text = "The current weight is drastically lower than when it was received";
                }
            }
        }

        private Models.ProcurementLocation GetProcurementDetails()
        {
            string schemaId = "", json = "";
            MaterialIssueSchema materialIssueSchema = null;

            List<FileInfo> files = GetSampleFilesForCurrentUser();
            schemaId = SamplesRequestedControl.Text.Split("#")[1].Split(" ")[0];
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                materialIssueSchema = (MaterialIssueSchema)JsonParser.Parse<MaterialIssueSchema>(json);
                if (materialIssueSchema.SchemaId == schemaId)
                {
                    JsonParser.Write(JsonParser.Stringify<MaterialIssueSchema>(materialIssueSchema), file.FullName);
                    break;
                }
            }

            return new Models.ProcurementLocation()
            {
                Quantity = materialIssueSchema.MaterialToBeIssued.ProcurementLocations.FirstOrDefault().Quantity,
                ApproxWeight = materialIssueSchema.MaterialToBeIssued.ProcurementLocations.FirstOrDefault().ApproxWeight
            };
        }

        private void BatchDetailsCaptionControl_Click(object sender, EventArgs e)
        {
            string message = "", batch = "", json = "";
            StringBuilder batchContents = new StringBuilder("Kindly provide details for the following items to complete this batch:\n\n");

            message = BatchDetailsCaptionControl.Text;
            if (message.Contains("materials"))
            {
                List<FileInfo> files = GetSampleFilesForCurrentUser();
                files.ForEach(file =>
                {
                    batch = file.Name.Split("batch")[1].Split(".")[0];
                    if (batch == activeBatch)
                    {
                        json = JsonParser.Read(file.FullName);
                        MaterialIssueSchema materialIssueSchema = (MaterialIssueSchema)JsonParser.Parse<MaterialIssueSchema>(json);
                        if (materialIssueSchema.Status == DONE)
                        {
                            batchContents.Append($"{materialIssueSchema}\n");
                        }
                    }
                });
                Utils.Utils.ShowMessageBox(batchContents.ToString(), "Notice", MessageBoxButtons.OK);
            }
        }
    }
}