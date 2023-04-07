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

namespace FPIS.Views
{
    public partial class ProcurementReceiveMaterialsUserControl : UserControl
    {
        private static ProcurementReceiveMaterialsUserControl instance;
        public const string DIRECTORY_NAME = "Material Procured";

        public static List<MaterialProcurementSchema> samplesRequested = new List<MaterialProcurementSchema>();
        public const string EN_ROUTE = "En Route";
        public const string ANALYZED = "Analyzed";
        public const string DONE = "Done";

        bool allowKeyboardShortcut = false;
        private ProcurementReceiveMaterialsUserControl()
        {
            InitializeComponent();
            SelectedDateControl.Text = GetDate(DateFormat.DATE_ONLY, DateTime.Now);
            LoadProductNames();
            LimitDateUserCanPick();
            LoadCachedData();
            EnableKeyboardShourtcut();
        }

        public static ProcurementReceiveMaterialsUserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProcurementReceiveMaterialsUserControl();
                    return instance;
                }
                else
                {
                    // This code will ensure the user's previous request shows all the time when they click 
                    // receive materials from the procurement section (if any). This is fine until the user
                    // tries to add new data and clicks on a different tab, they will lose their new entry
                    //instance.LoadCachedData();
                    return instance;
                }
            }
            set
            {
                instance = value;
            }
        }
        public static int LiveCharacterCount(int maxLength, string contents)
        {
            int length = contents.Length;
            int charactersTyped = maxLength - length;
            return charactersTyped;
        }

        private void RemarksControl_KeyUp(object sender, KeyEventArgs e)
        {
            string remarks = RemarksControl.Text;
            int charactersTyped = LiveCharacterCount(500, remarks);
            RemarksCaptionControl.Text = $"Remarks ({charactersTyped} characters)";
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
        private void QuantityControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isHandled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
            e.Handled = isHandled;
        }
        private void LoadProductNames()
        {
            var products = new ProductService(new()).GetProductsByType("raw materials");
            foreach (Product product in products)
            {
                ProductControl.Items.Add(product);
            }
        }
        private void SaveProcurementRecords_Click(object sender, EventArgs e)
        {
            PerformValidations();
            bool shouldSave = true;

            if (!shouldSave)
            {
                return;
            }
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox("Do you wish to proceed?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userReponseToProceed != DialogResult.Yes)
            {
                return;
            }

            MaterialProcurement materialProcured = SaveMaterialProcuredRecord();
            if (materialProcured != null)
            {
                ResetFields();
                Utils.Utils.ShowMessageBox("Raw material procured has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private MaterialProcurement SaveMaterialProcuredRecord()
        {
            Models.MaterialProcurement materialProcurement = GetMaterialToBeProcured();
            MaterialProcurementService materialProcurementService = new MaterialProcurementService(new());
            var materialProcured = materialProcurementService.SaveMaterialProcuredRecord(materialProcurement);
            SaveMaterialReceivedRecord(materialProcured.Id);
            return materialProcured;
        }
        private void SaveMaterialReceivedRecord(Guid materialBeingProcured)
        {
            Receiving materialReceivedRecord = GetMaterialToBeReceived(materialBeingProcured);
            ReceivingService receivingService = new ReceivingService(new());
            receivingService.SaveMaterialReceivedRecord(materialReceivedRecord);
        }
        public void ValidateFields(string supplier, string truck, string quantity, string unit, string materialProcured, string warehouse, string lot, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateSupplier(supplier, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateTruckNumber(truck, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateQuantity(quantity, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateUnit(unit, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateProduct(materialProcured, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateWarehouse(warehouse, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateLot(lot, ref shouldSave, ref isErrorMessageDisplayed);

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
        public void ValidateQuantity(string quantity, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (quantity.Length == 0)
            {
                DisplayErrorMessage(QuantityErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the quantity received");
                return;
            }
        }
        public void ValidateUnit(string unit, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (unit.Length == 0)
            {
                DisplayErrorMessage(UnitsErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the unit of measurement");
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
        public void ValidateWarehouse(string warehouse, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (warehouse.Length == 0)
            {
                DisplayErrorMessage(WarehouseErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the warehouse you'll be storing the raw-material received");
                return;
            }
        }
        public void ValidateLot(string lot, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (lot.Length == 0)
            {
                DisplayErrorMessage(LotErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the lot you'll be storing the raw-material received");
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
                WarehouseErrorCaption.Text =
                QuantityErrorCaption.Text =
                UnitsErrorCaption.Text =
                TruckNumberErrorCaption.Text =
                ProductErrorCaption.Text =
                LotErrorCaption.Text = string.Empty;
        }
        public void ResetFields()
        {
            SupplierControl.Text =
                TruckNumberControl.Text =
                QuantityControl.Text =
                ProductControl.Text =
                RemarksControl.Text =
                WarehouseControl.Text =
                UnitsControl.Text =
                LotControl.Text =
                string.Empty;
            DoneControl.Text = "Ready";
            DoneControl.Image = Properties.Resources.not_done_light;
            AbortProcurementRecords.Enabled = false;
            StartSampleRequest.Enabled = true;
            SwitchDateControl.Checked = true;
            ProductControl.StartIndex = -1;
            RemarksCaptionControl.Text = $"Remarks ({500} characters)";
        }
        private MaterialProcurement GetMaterialToBeProcured()
        {
            Product selected = (Product)ProductControl.SelectedItem;
            return new MaterialProcurement()
            {
                ProductId = selected.Id,
                Location = WarehouseControl.Text.Trim(),
                Date = DateOnly.FromDateTime(PickDateControl.Value),
                Remarks = RemarksControl.Text.Trim(),
                Type = "Receiving",
                UserId = Guid.Parse(Main.LOGGED_USER_ID),
                Lot = LotControl.Text.Trim(),
            };
        }
        private Receiving GetMaterialToBeReceived(Guid materialBeingProcured)
        {
            int quantity;
            int.TryParse(QuantityControl.Text, out quantity);
            return new Receiving()
            {
                Supplier = SupplierControl.Text.Trim(),
                TruckNumber = TruckNumberControl.Text.Trim(),
                Quantity = quantity,
                Units = UnitsControl.Text,
                MaterialProcurementId = materialBeingProcured
            };
        }
        private bool PerformValidations()
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            ValidateFields(SupplierControl.Text.Trim(),
                TruckNumberControl.Text.Trim(),
                QuantityControl.Text.Trim(),
                UnitsControl.Text,
                ProductControl.Text,
                WarehouseControl.Text,
                LotControl.Text,
                ref shouldSave);

            return shouldSave;
        }
        private void StartSampleRequest_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;
            shouldSave = PerformValidations();

            if (!shouldSave)
            {
                return;
            }

            MaterialProcurement materialToBeProcured = GetMaterialToBeProcured();
            Receiving materialToBeReceived = GetMaterialToBeReceived(materialToBeProcured.Id);
            DialogResult userOption = Utils.Utils.ShowMessageBox("Do you want to send a request to Quality Control with the following details:\n\n" +
                $"Product: {ProductControl.Text}\n" +
                $"Warehouse: {materialToBeProcured.Location}\n" +
                $"Lot : {materialToBeProcured.Location}\n" +
                $"Date: {materialToBeProcured.Date.ToLongDateString()}\n" +
                $"----------\n" +
                $"Supplier: {materialToBeReceived.Supplier}\n" +
                $"Truck #: {materialToBeReceived.TruckNumber}\n" +
                $"Quantity Received: {materialToBeReceived.Quantity}\n" +
                $"Unit : {materialToBeReceived.Units}\n" +
                $"{((materialToBeProcured.Remarks == string.Empty) ? "" : $"Remarks: {materialToBeProcured.Remarks}")}"
                , "Confirm Request"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if(userOption == DialogResult.No)
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
            if(sampleCreated == null)
            {
                Utils.Utils.ShowMessageBox(
                    "We could not create the sample you requested. Kindly try again later 🙂"
                    , "Error Occured"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }
            int totalNumberOfSamplesRequested = GetSampleFilesForCurrentUser().Length + 1;
            MaterialProcurementSchema materialProcurementSchema = new MaterialProcurementSchema()
            {
                SampleDetail = sampleCreated.SampleDetails.FirstOrDefault()
                ,
                Receiving = materialToBeReceived
                ,
                SchemaId = $"{totalNumberOfSamplesRequested}"
                , Status = EN_ROUTE
            };
            sampleCreated.SampleDetails.Clear();
            materialToBeReceived.MaterialProcurement = materialToBeProcured;
            JsonParser.Serialize<MaterialProcurementSchema>(materialProcurementSchema, Path.Combine(DIRECTORY_NAME
                                                            , $"material-procured" +
                                                            $"-{sampleCreated.Date.Month}" +
                                                            $"-{sampleCreated.Date.Day}" +
                                                            $"-{sampleCreated.Time.Hour}" +
                                                            $"-{sampleCreated.Time.Minute}" +
                                                            $"-{sampleCreated.Time.Second}" +
                                                            $".json"));
            FreezeFields();
            UpdateUIAfterRequestingSample();
            LoadCachedData();
        }
        private void FreezeFields()
        {
            IterateThroughPanel(ReceivingSectionControl, false);
            IterateThroughPanel(DateProcuredSection, false);
            IterateThroughPanel(MaterialProcurementSection, false);
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
                    control.Enabled = state;
                }
            }
        }
        private void UpdateUIAfterRequestingSample()
        {
            allowKeyboardShortcut = true;
            StartSampleRequest.Enabled = false;
            AbortProcurementRecords.Enabled = true;
            SaveProcurementRecords.Enabled = false;
            DoneControl.Text = EN_ROUTE;
            DoneControl.Image = Properties.Resources.not_done_light;
            ShowSnackBar("Sample was requested successfully! 👍");
            EnableKeyboardShourtcut();
        }
        // TODO: WILL BE USED WHEN QC PROVIDES RESULTS ON SAMPLE
        public void UpdateUIAfterProcessingSample()
        {
            StartSampleRequest.Enabled = false;
            AbortProcurementRecords.Enabled = false;
            SaveProcurementRecords.Enabled = true;
            DoneControl.Text = "Done";
            DoneControl.Image = Properties.Resources.done_light;
        }
        public void UpdateUIWhenProcessingStarts()
        {
            StartSampleRequest.Enabled = false;
            SaveProcurementRecords.Enabled = false;
            AbortProcurementRecords.Enabled = false;
            DoneControl.Text = ANALYZED;
            DoneControl.Image = Properties.Resources.not_done_light;
            ShowSnackBar("Sample is analyzed at the lab ATM! 👍");
        }
        private void EnableKeyboardShourtcut()
        {
            DoneControl.Focus();
        }
        private void CloseSnackbarControl_Click(object sender, EventArgs e)
        {
            EnableKeyboardShourtcut();
            HideSnackBar();
        }
        private void LoadCachedData()
        {
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
                ReceivingSectionControl.Location = new Point(25, 40);
                MaterialProcurementSchema cachedData = (MaterialProcurementSchema)JsonParser
                                                        .Deserialize<MaterialProcurementSchema>
                                                        (files[0].FullName);
                PopulateFields(cachedData);
                return;
            }
            ListOfRequestedSamplesControl.Visible = true;
            ReceivingSectionControl.Location = new Point(25, 89);
        }
        private void UnfreezeFields()
        {
            IterateThroughPanel(ReceivingSectionControl, true);
            IterateThroughPanel(DateProcuredSection, true);
            IterateThroughPanel(MaterialProcurementSection, true);
            StartSampleRequest.Enabled = true;
        }
        private void AddNewRequest_Click(object sender, EventArgs e)
        {
            StartNewSampleRequest();
        }
        private void StartNewSampleRequest()
        {
            allowKeyboardShortcut = false;
            HideSnackBar();
            UnfreezeFields();
            ResetFields();
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
            WarehouseControl.Text = materialProcurement.Location;
            PickDateControl.Value = materialProcurement.Date.ToDateTime(TimeOnly.MinValue);
            RemarksControl.Text = materialProcurement.Remarks;
            LotControl.Text = materialProcurement.Lot;
            SupplierControl.Text = receiving.Supplier;
            QuantityControl.Text = $"{receiving.Quantity}";
            UnitsControl.Text = receiving.Units;
            TruckNumberControl.Text = receiving.TruckNumber;
            SwitchDateControl.Checked = false;
            switch (cachedData.Status.ToLower().Trim())
            {
                case "en route":
                    UpdateUIAfterRequestingSample();
                    break;
                case "analyzed":
                    UpdateUIWhenProcessingStarts();
                    break;
            }
            FreezeFields();
        }

        private void ListOfRequestedSamplesControl_LoadClick(object sender, EventArgs e)
        {
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
                MaterialProcurementSchema cachedData = (MaterialProcurementSchema)JsonParser
                                                        .Deserialize<MaterialProcurementSchema>
                                                        (file.FullName);
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
            string selectedItem = ViewSampleRequestedControl.Text;
            samplesRequested.Clear();
            ViewSampleRequestedControl.Items.Clear();
            FileInfo[] allFiles = JsonParser.GetFiles(Path.Combine(DIRECTORY_NAME));
            List<FileInfo> files = new List<FileInfo>();
            foreach (FileInfo file in allFiles)
            {
                MaterialProcurementSchema cachedData = (MaterialProcurementSchema)JsonParser
                                                    .Deserialize<MaterialProcurementSchema>
                                                    (file.FullName);
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
            LoadCachedData();
        }
    }
}