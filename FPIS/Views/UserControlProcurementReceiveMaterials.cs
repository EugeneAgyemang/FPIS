using FPIS.Models;
using FPIS.Services;
using FPIS.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Text.Json;
using FPIS.Data;
using System.Drawing.Text;

namespace FPIS.Views
{
    public partial class UserControlProcurementReceiveMaterials : UserControl
    {
        private static UserControlProcurementReceiveMaterials instance;
        public const string DIRECTORY_NAME = "Material Procured";

        public static List<MaterialProcurementSchema> samplesRequested = new List<MaterialProcurementSchema>();
        public const string EN_ROUTE = "  En Route";
        public const string ANALYZED = "  Analyzed";
        public const string DONE = "  Done";
        public const string READY = "  Ready";
        public const string REJECTED = "  Rejected";
        private const string REJECTED_PHRASE = "the sample you requested was rejected!";

        bool allowKeyboardShortcut = false;

        private string sampleId;
        public UserControlProcurementReceiveMaterials()
        {
            InitializeComponent();
            sampleId = string.Empty;
            SelectedDateControl.Text = GetDate(DateFormat.DATE_ONLY, DateTime.Now);
            Snackbar.Visible = false;
            LoadProductNames();
            LimitDateUserCanPick();
            LoadCachedData();
            EnableKeyboardShourtcut();
        }

        private static string GetDate(DateFormat dateFormat, DateTime date)
        {
            DateTime currentDate = date;
            string currentDateAsString = "";
            switch (dateFormat)
            {
                case DateFormat.DATE_ONLY:
                    currentDateAsString = $"{currentDate.DayOfWeek}, " +
                        $"{GetMonthName(currentDate.Month)} " +
                        $"{currentDate.Day} " +
                        $"{currentDate.Year}";
                    break;
                case DateFormat.TIME_ONLY:
                    currentDateAsString = currentDate.ToLongTimeString();
                    break;
                case DateFormat.DATE_AND_TIME:
                    currentDateAsString = $"{currentDate.DayOfWeek}, " +
                        $"{GetMonthName(currentDate.Month)} " +
                        $"{currentDate.Day} " +
                        $"{currentDate.Year} " +
                        $"{currentDate.ToLongTimeString()}";
                    break;
            }
            return currentDateAsString;
        }
        public static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                default:
                    return "December";
            }
        }

        private void SwitchDateControl_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitchDate();
        }
        private void ToggleSwitchDate()
        {
            string[] captions = { "Use a new date", "Use today's date" };
            string[] switchDateCaptions = { "I'm using the current date", "I'm using the new date you pick" };
            string captionOfSwitchDateControl = SwitchDateControl.Text;
            if (captionOfSwitchDateControl == captions[1])
            {
                SwitchDateControl.Text = captions[0];
                SwitchDateCaptionControl.Text = switchDateCaptions[0];
                PickDateControl.Enabled = false;
                PickDateControl.Value = DateTime.Now.Date;
                return;
            }
            SwitchDateControl.Text = captions[1];
            SwitchDateCaptionControl.Text = switchDateCaptions[1];
            PickDateControl.Enabled = true;
        }
        private void PickDateControl_ValueChanged(object sender, EventArgs e)
        {
            DateTime datePicked = PickDateControl.Value;
            SelectedDateControl.Text = GetDate(DateFormat.DATE_ONLY, datePicked);
        }
        private void LimitDateUserCanPick()
        {
            PickDateControl.MaxDate = DateTime.Now;
        }
        private void LoadProductNames()
        {
            ProductControl.Items.Clear();
            var products = new ProductService(new()).GetProductsByType("raw materials");
            foreach (Product product in products)
            {
                ProductControl.Items.Add(product);
            }
        }
        private void SaveProcurementRecords_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;
            shouldSave = PerformValidations(sendingSample: false);

            if (!shouldSave)
            {
                return;
            }
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox($"{((RemarksControl.Text == string.Empty) ? "Looks like you forgot to provide a remark 😟\n\n" : string.Empty)}" +
                                                    $"Do you wish to proceed{((RemarksControl.Text == string.Empty) ? " anyways" : string.Empty)}" +
                                                    $"{((RemarksControl.Text == string.Empty) ? " without adding any remarks?" : "?")}\n\n" +
                                                    $"I'll notify the production department of the newly added material"
                                                    , "Continue"
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question);
            //DialogResult userReponseToProceed = Utils.Utils
            //                                        .ShowMessageBox("Do you wish to save the details provided?\n\n" +
            //                                        "I'll notify the production department of the newly added material"
            //                                        , "Confirm Save"
            //                                        , MessageBoxButtons.YesNo
            //                                        , MessageBoxIcon.Question);
            if (userReponseToProceed == DialogResult.No)
            {
                return;
            }
            MaterialProcurement materialProcured = SaveMaterialProcuredRecord();
            if (materialProcured != null)
            {
                DeleteCachedFile();
                ResetFields();
                Utils.Utils.ShowMessageBox("Raw material record has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private MaterialProcurement SaveMaterialProcuredRecord()
        {
            MaterialProcurement materialProcurement = GetMaterialToBeProcured();
            MaterialProcurementService materialProcurementService = new MaterialProcurementService(new());
            var materialProcured = materialProcurementService.SaveMaterialProcuredRecord(materialProcurement);
            SaveMaterialReceivedRecord(materialProcured.Id);
            return materialProcured;
        }
        private void SaveMaterialReceivedRecord(Guid materialBeingProcured)
        {
            Receiving materialReceivedRecord = GetMaterialToBeReceived(materialBeingProcured);
            ReceivingService receivingService = new ReceivingService(new());
            materialReceivedRecord = receivingService.SaveMaterialReceivedRecord(materialReceivedRecord);
        }

        public void ValidateFields(string supplier
                                    , string truck
                                    , string country
                                    , string city
                                    , ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateSupplier(supplier, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateTruckNumber(truck, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateCountry(country, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateCity(city, ref shouldSave, ref isErrorMessageDisplayed);
        }
        public void ValidateSupplier(string supplier, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (supplier.Length == 0)
            {
                DisplayErrorMessage(SupplierErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the supplier");
                return;
            }
        }
        public void ValidateTruckNumber(string truckNumber, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (truckNumber.Length == 0)
            {
                DisplayErrorMessage(TruckNumberErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the truck number");
                return;
            }
        }

        public void ValidateProduct(string product, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (product.Length == 0)
            {
                DisplayErrorMessage(ProductErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the product being procured");
                return;
            }
        }

        public void ValidateCity(string lot, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (lot.Length == 0)
            {
                DisplayErrorMessage(CityErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the city the raw-material received came from");
                return;
            }
        }

        public void ValidateCountry(string lot, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (lot.Length == 0)
            {
                DisplayErrorMessage(CountryErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the country the raw-material received came from");
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
            SupplierErrorCaption.Text =
                TruckNumberErrorCaption.Text =
                ProductErrorCaption.Text =
                CountryErrorControl.Text =
                CityErrorControl.Text = string.Empty;
        }
        public void ResetFields()
        {
            SupplierControl.Text =
                TruckNumberControl.Text =
                ProductControl.Text =
                CountryControl.Text =
                CityControl.Text =
                RemarksControl.Text =
                string.Empty;
            DoneControl.Text = READY;
            DoneControl.Icon = Properties.Resources.not_done_light;
            AbortProcurementRecords.Enabled = false;
            StartSampleRequest.Enabled = true;
            SwitchDateControl.Checked = true;
            PickDateControl.Enabled = false;
            ProductControl.StartIndex = -1;
            ReceivingSectionControl.Enabled =
                MaterialProcurementLastSection.Enabled = false;
            ViewSampleRequestedControl.StartIndex = -1;
        }

        private MaterialProcurement GetMaterialToBeProcured()
        {
            Product selected = (Product)ProductControl.SelectedItem;
            return new MaterialProcurement()
            {
                ProductId = selected.Id,
                Type = "Receiving",
                UserId = Guid.Parse(Main.LOGGED_USER_ID),
                Date = DateOnly.FromDateTime(PickDateControl.Value),
                Remarks = RemarksControl.Text
            };
        }
        private Receiving GetMaterialToBeReceived(Guid materialBeingProcured)
        {
            return new Receiving()
            {
                Supplier = SupplierControl.Text.Trim(),
                TruckNumber = TruckNumberControl.Text.Trim(),
                Quantity = 0,
                Units = string.Empty,
                MaterialProcurementId = materialBeingProcured,
                GrossWeight = string.Empty,
                NetWeight = string.Empty,
                Country = CountryControl.Text.Trim(),
                City = CityControl.Text.Trim()
            };
        }

        private bool PerformValidations(bool sendingSample)
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            bool isErrorMessageDisplayed = false;

            if (sendingSample)
            {
                ValidateProduct(ProductControl.Text.Trim(), ref shouldSave, ref isErrorMessageDisplayed);
                return shouldSave;
            }

            ValidateFields(SupplierControl.Text.Trim(),
                TruckNumberControl.Text.Trim(),
                CountryControl.Text.Trim(),
                CityControl.Text.Trim(),
                ref shouldSave);

            return shouldSave;
        }
        private void StartSampleRequest_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;
            shouldSave = PerformValidations(sendingSample: true);

            if (!shouldSave)
            {
                return;
            }

            MaterialProcurement materialToBeProcured = GetMaterialToBeProcured();
            Receiving materialToBeReceived = GetMaterialToBeReceived(materialToBeProcured.Id);
            materialToBeReceived.MaterialProcurement = materialToBeProcured;
            DialogResult userOption = Utils.Utils.ShowMessageBox($"Do you want to send a request to Quality Control to analyze {ProductControl.Text}?"
                , "Confirm Request"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (userOption == DialogResult.No)
            {
                return;
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
                , new List<AnalysisSampleBindingItem>()
                    {
                        new AnalysisSampleBindingItem()
                        {
                            Id = new AnalysisProductService(new())
                                .GetAnalysisProductByProductId(
                                    new ProductService(new())
                                    .GetProductByName(ProductControl.Text)
                                    .Id)
                            .AnalysisItemId
                        }
                    }
                );
            if (sampleCreated == null)
            {
                Utils.Utils.ShowMessageBox(
                    "We could not create the sample you requested. Kindly try again later 🙂"
                    , "Error Occured"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }
            int totalNumberOfSamplesRequested = GetLastSchemaId();
            MaterialProcurementSchema materialProcurementSchema = new MaterialProcurementSchema()
            {
                SampleDetail = sampleCreated.SampleDetails.FirstOrDefault()
                ,
                Receiving = materialToBeReceived
                ,
                SchemaId = $"{totalNumberOfSamplesRequested}"
                ,
                Status = EN_ROUTE
            };
            sampleCreated.SampleDetails.Clear();


            string json = JsonParser.Stringify<MaterialProcurementSchema>(materialProcurementSchema);
            JsonParser.Write(json, Path.Combine(DIRECTORY_NAME
                                    , $"material-procured" +
                                    $"-{sampleCreated.Date.Month}" +
                                    $"-{sampleCreated.Date.Day}" +
                                    $"-{sampleCreated.Time.Hour}" +
                                    $"-{sampleCreated.Time.Minute}" +
                                    $"-{sampleCreated.Time.Second}" +
                                    $"-{materialProcurementSchema.SchemaId}" +
                                    $".json"));
            FreezeFields();
            UpdateUIAfterRequestingSample(ProductControl.Text);
            LoadCachedData();
        }
        private void FreezeFields()
        {
            //IterateThroughPanel(MaterialProcurementFirstSection, false);
            //IterateThroughPanel(DateProcuredSection, false);
            //IterateThroughPanel(MaterialProcurementLastSection, false);
            ProductControl.Enabled = false;
        }
        private void IterateThroughPanel(Panel panel, bool state)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is MaterialTextBox ||
                    control is MaterialComboBox ||
                    control is MaterialSwitch ||
                    control is MaterialMultiLineTextBox2 ||
                    control is DateTimePicker)
                {
                    if (control.Name == "ReceivingSectionControl"
                        || control.Name == "MaterialProcurementLastSection")
                    {
                        continue;
                    }
                    control.Enabled = state;
                }
            }
        }
        private void UpdateUIAfterRequestingSample(string product)
        {
            StartSampleRequest.Enabled = false;
            AbortProcurementRecords.Enabled = true;
            SaveProcurementRecords.Enabled = false;
            DoneControl.Text = EN_ROUTE;
            DoneControl.Icon = Properties.Resources.not_done_light;
            ShowSnackBar($"{product} analysis requested successfully! 👍");
            ReceivingSectionControl.Enabled =
                MaterialProcurementLastSection.Enabled = false;
            EnableKeyboardShourtcut();
            Focus();
        }
        public void UpdateUIAfterProcessingSample(string product)
        {
            StartSampleRequest.Enabled = false;
            AbortProcurementRecords.Enabled = false;
            SaveProcurementRecords.Enabled = true;
            DoneControl.Text = DONE;
            DoneControl.Icon = Properties.Resources.done_light;
            ShowSnackBar($"{product} analysis completed successfully! 👍");
            ReceivingSectionControl.Enabled =
                MaterialProcurementLastSection.Enabled = true;
            EnableKeyboardShourtcut();
        }
        public void UpdateUIWhenProcessingStarts(string product)
        {
            StartSampleRequest.Enabled = false;
            SaveProcurementRecords.Enabled = false;
            AbortProcurementRecords.Enabled = false;
            DoneControl.Text = ANALYZED;
            DoneControl.Icon = Properties.Resources.not_done_light;
            ShowSnackBar($"{Utils.Utils.TruncateLengthyText(product, 10)} is analyzed at the lab ATM! 👍");
            ReceivingSectionControl.Enabled =
                MaterialProcurementLastSection.Enabled = false;
            EnableKeyboardShourtcut();
        }

        private void UpdateUIAfterAbortingRequest()
        {
            StartSampleRequest.Enabled = false;
            AbortProcurementRecords.Enabled = false;
            SaveProcurementRecords.Enabled = false;
            DoneControl.Text = READY;
            ReceivingSectionControl.Enabled =
                MaterialProcurementLastSection.Enabled = false;
            DoneControl.Icon = Properties.Resources.not_done_light;
            ShowSnackBar("Request was aborted successfully! 👍");
            EnableKeyboardShourtcut();
        }

        private void UpdateUIAfterRejectingSample()
        {
            StartSampleRequest.Enabled = false;
            AbortProcurementRecords.Enabled = true;
            SaveProcurementRecords.Enabled = false;
            DoneControl.Text = REJECTED;
            ReceivingSectionControl.Enabled =
                MaterialProcurementLastSection.Enabled = false;
            DoneControl.Icon = Properties.Resources.rejected_light;
            ShowSnackBar($"{REJECTED_PHRASE} 👎");
            EnableKeyboardShourtcut();
        }

        private void EnableKeyboardShourtcut()
        {
            allowKeyboardShortcut = true;
            DoneControl.Focus();
        }
        private void CloseSnackbarControl_Click(object sender, EventArgs e)
        {
            EnableKeyboardShourtcut();
            HideSnackBar();
        }
        private void LoadCachedData()
        {
            string json;
            ViewSampleRequestedControl.Items.Clear();
            FileInfo[] files = GetSampleFilesForCurrentUser();
            int cachedRequests = files.Length;
            if (cachedRequests == 0)
            {
                return;
            }
            if (cachedRequests == 1)
            {
                ListOfRequestedSamplesControl.Visible = false;
                //ReceivingSectionControl.Location = new Point(25, 40);
                json = JsonParser.Read(files[0].FullName);
                MaterialProcurementSchema cachedData = (MaterialProcurementSchema)JsonParser
                                                        .Parse<MaterialProcurementSchema>
                                                        (json);
                PopulateFields(cachedData);
                return;
            }
            ListOfRequestedSamplesControl.Visible = true;
            //ReceivingSectionControl.Location = new Point(25, ReceivingSectionControl.Location.Y + 40);
            //ProductControl.Location = new Point(25, ProductControl.Location.Y + 40);
            //SyncControl.Location = new Point(SyncControl.Location.X, SyncControl.Location.Y + 40);
        }
        private void UnfreezeFields()
        {
            //IterateThroughPanel(MaterialProcurementFirstSection, true);
            //IterateThroughPanel(DateProcuredSection, true);
            //IterateThroughPanel(MaterialProcurementLastSection, true);
            ProductControl.Enabled = true;
            StartSampleRequest.Enabled = true;
        }
        private void AddNewRequest_Click(object sender, EventArgs e)
        {
            StartNewSampleRequest();
        }
        private void StartNewSampleRequest()
        {
            allowKeyboardShortcut = false;
            SaveProcurementRecords.Enabled = false;
            HideSnackBar();
            UnfreezeFields();
            ResetFields();
            ResetErrorCaptions();
        }

        private void OpenHelper_Click(object sender, EventArgs e)
        {
            Utils.Utils.ShowMessageBox("If you wish to send some more samples to Quality" +
                " Control click the plus (+) icon to the left.\n\nFeel free to send as " +
                "many samples to Quality Control 👍\n\nYou can always access this command" +
                " using the keyboard shortcuts Ctrl + N", "Info", MessageBoxButtons.OK);
        }

        private void ImageActionControl_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ImageActionControl_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).SizeMode = PictureBoxSizeMode.Normal;
        }

        private void ProcurementReceiveMaterialsUserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (!allowKeyboardShortcut)
            {
                return;
            }
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.N)
                {
                    StartNewSampleRequest();
                }
            }
        }
        private void HideSnackBar()
        {
            Snackbar.Visible = false;
        }
        private void ShowSnackBar(string message)
        {
            Snackbar.Visible = true;
            SnackbarCaptionControl.Text = message;
        }
        private void PopulateFields(MaterialProcurementSchema cachedData)
        {
            Receiving receiving = cachedData.Receiving;
            MaterialProcurement materialProcurement = receiving.MaterialProcurement;

            ProductControl.Text = new ProductService(new())
                                        .GetProductById
                                        (materialProcurement.ProductId)
                                        .ToString();
            ProductErrorCaption.Text = string.Empty;
            sampleId = $"{cachedData.SampleDetail.SampleId}";
            switch (cachedData.Status.ToLower().Trim())
            {
                case "en route":
                    UpdateUIAfterRequestingSample(ProductControl.Text);
                    break;
                case "analyzed":
                    UpdateUIWhenProcessingStarts(ProductControl.Text);
                    break;
                case "done":
                    UpdateUIAfterProcessingSample(ProductControl.Text);
                    break;
                case "rejected":
                    UpdateUIAfterRejectingSample();
                    break;
            }
            FreezeFields();
        }

        private void ListOfRequestedSamplesControl_LoadClick(object sender, EventArgs e)
        {
            string json;
            string sampleRequestSelected = ViewSampleRequestedControl.Text;
            if (sampleRequestSelected == string.Empty)
            {
                Utils.Utils.ShowMessageBox("Kindly select any of the sample's you requested earlier"
                                            , "Info"
                                            , MessageBoxButtons.OK);
                return;
            }

            foreach (FileInfo file in GetSampleFilesForCurrentUser())
            {
                if (file.Name.StartsWith("schema"))
                {
                    continue;
                }
                json = JsonParser.Read(file.FullName);
                MaterialProcurementSchema cachedData = (MaterialProcurementSchema)JsonParser
                                                        .Parse<MaterialProcurementSchema>
                                                        (json);
                string schemaId = sampleRequestSelected.Split("#")[1].Split(" ")[0];
                if (schemaId == cachedData.SchemaId)
                {
                    PopulateFields(cachedData);
                    break;
                }
            }
        }
        private FileInfo[] GetSampleFilesForCurrentUser()
        {
            string json;
            string selectedItem = ViewSampleRequestedControl.Text;
            samplesRequested.Clear();
            ViewSampleRequestedControl.Items.Clear();
            FileInfo[] allFiles = JsonParser.GetFiles(Path.Combine(DIRECTORY_NAME));
            List<FileInfo> files = new List<FileInfo>();
            foreach (FileInfo file in allFiles)
            {
                if (file.Name.StartsWith("schema"))
                {
                    continue;
                }
                json = JsonParser.Read(file.FullName);
                MaterialProcurementSchema cachedData = (MaterialProcurementSchema)JsonParser.Parse<MaterialProcurementSchema>(json);
                if (cachedData.SampleDetail.Sample.UserId == Guid.Parse(Main.LOGGED_USER_ID))
                {
                    files.Add(file);
                    samplesRequested.Add(cachedData);
                }
            }
            ViewSampleRequestedControl.Items.AddRange(samplesRequested.ToArray());
            ViewSampleRequestedControl.Text = selectedItem;
            return files.ToArray();
        }

        private void SyncControl_Click(object sender, EventArgs e)
        {
            string guidDelimeter = "-";
            string json;
            if (sampleId.Contains(guidDelimeter))
            {
                ResetFields();
                foreach (FileInfo file in GetSampleFilesForCurrentUser())
                {
                    json = JsonParser.Read(file.FullName);
                    MaterialProcurementSchema materialProcurementSchema = (MaterialProcurementSchema)JsonParser.Parse<MaterialProcurementSchema>(json);
                    if (materialProcurementSchema.SampleDetail.SampleId == Guid.Parse(sampleId))
                    {
                        PopulateFields(materialProcurementSchema);
                    }
                }
                return;
            }
            LoadCachedData();
        }

        private void AbortProcurementRecords_Click(object sender, EventArgs e)
        {
            string json;
            bool isRejected = SnackbarCaptionControl.Text.ToLower().Contains(REJECTED_PHRASE);
            DialogResult userOption = Utils.Utils.ShowMessageBox($"{(isRejected ? "Quality Control rejected the sample you sent.\n\nI'll wipe the record for the rejected sample off your device." : "Do you truly want to cancel this request?\n\nThis action cannot be undone should you choose yes!")}"
                                                                    , $"Confirm {(isRejected ? "Reject" : "Abort")}"
                                                                    , MessageBoxButtons.YesNo
                                                                    , MessageBoxIcon.Question);
            if (userOption == DialogResult.No)
            {
                return;
            }
            FileInfo[] files = GetSampleFilesForCurrentUser();
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                MaterialProcurementSchema materialProcurementSchema = (MaterialProcurementSchema)JsonParser.Parse<MaterialProcurementSchema>(json);
                if ((materialProcurementSchema.Status.ToLower().Trim() == EN_ROUTE.ToLower().Trim()
                    || materialProcurementSchema.Status.ToLower().Trim() == REJECTED.ToLower().Trim())
                    && materialProcurementSchema.SampleDetail.SampleId == Guid.Parse(sampleId))
                {
                    JsonParser.DeleteFile(Path.Combine(DIRECTORY_NAME, file.Name));
                    if (!isRejected)
                    {
                        Sample sample = new AnalysisService(new())
                                            .DeleteSample
                                            (materialProcurementSchema
                                                .SampleDetail
                                                .Sample);
                        Utils.Utils.ShowMessageBox($"The sample you requested on {sample.Date.ToLongDateString()} at {sample.Time.ToShortTimeString()} is cancelled successfully! I'll keep Quality Control updated about your decision"
                                                    , "Info", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Utils.Utils.ShowMessageBox("Record on rejected material has been wiped successfully!", "Info", MessageBoxButtons.OK);
                    }
                    ResetErrorCaptions();
                    ResetFields();
                    LoadCachedData();
                    UpdateUIAfterAbortingRequest();
                    return;
                }
            }
        }
        private int GetLastSchemaId()
        {
            string json;
            string schemaFileName = "schema-received-id.json";
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
        private void UpdateUIAfterSavingProcurement()
        {
            StartSampleRequest.Enabled = false;
            AbortProcurementRecords.Enabled = false;
            SaveProcurementRecords.Enabled = false;
            DoneControl.Text = READY;
            DoneControl.Image = Properties.Resources.not_done_light;
            ShowSnackBar("Material procured successfully! 👍");
            EnableKeyboardShourtcut();
        }
        private void DeleteCachedFile()
        {
            string json;
            FileInfo[] files = GetSampleFilesForCurrentUser();
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                MaterialProcurementSchema materialProcurementSchema = (MaterialProcurementSchema)JsonParser.Parse<MaterialProcurementSchema>(json);
                if (materialProcurementSchema.Status.ToLower().Trim() == "done"
                    && materialProcurementSchema.SampleDetail.SampleId == Guid.Parse(sampleId))
                {
                    JsonParser.DeleteFile(Path.Combine(DIRECTORY_NAME, file.Name));
                    LoadCachedData();
                    UpdateUIAfterSavingProcurement();
                    return;
                }
            }
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
    }
}