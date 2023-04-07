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
        private ProcurementReceiveMaterialsUserControl()
        {
            InitializeComponent();
            SelectedDateControl.Text = GetDate(DateFormat.DATE_ONLY, DateTime.Now);
            LoadProductNames();
            LimitDateUserCanPick();
            LoadCachedData();
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
                    "We could not create the sample you created. Kindly try again later 🙂"
                    , "Error Occured"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }
            FreezeFields();
            MaterialProcurementSchema materialProcurementSchema = new MaterialProcurementSchema()
            {
                SampleDetail = sampleCreated.SampleDetails.FirstOrDefault()
                ,
                Receiving = materialToBeReceived
            };
            sampleCreated.SampleDetails.Clear();
            materialToBeReceived.MaterialProcurement = materialToBeProcured;
            JsonParser.Serialize<MaterialProcurementSchema>(materialProcurementSchema, Path.Combine("Material Procured"
                                                            , $"material-procured" +
                                                            $"-{sampleCreated.Date.Month}" +
                                                            $"-{sampleCreated.Date.Day}" +
                                                            $"-{sampleCreated.Time.Hour}" +
                                                            $"-{sampleCreated.Time.Minute}" +
                                                            $"-{sampleCreated.Time.Second}" +
                                                            $".json"));
            UpdateUIAfterRequestingSample();
        }
        private void FreezeFields()
        {
            IterateThroughPanel(ReceivingSetionControl);
            IterateThroughPanel(DateProcuredSection);
            IterateThroughPanel(MaterialProcurementSection);
        }
        private void IterateThroughPanel(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is MaterialTextBox ||
                    control is MaterialComboBox ||
                    control is MaterialSwitch ||
                    control is MaterialMultiLineTextBox2 ||
                    control is DateTimePicker)
                {
                    control.Enabled = false;
                }
            }
        }
        private void UpdateUIAfterRequestingSample()
        {
            StartSampleRequest.Enabled = false;
            DoneControl.Text = "En Route";
            SwitchDateCaptionControl.Focus();
            Snackbar.Visible = true;
        }
        public void UpdateUIAfterProcessingSample()
        {
            StartSampleRequest.Enabled = true;
            DoneControl.Text = "Done";
        }

        private void CloseSnackbarControl_Click(object sender, EventArgs e)
        {
            Snackbar.Visible = false;
        }
        private void LoadCachedData()
        {
            FileInfo[] files = JsonParser.GetFIles(Path.Combine("Material Procured"));
            int cachedMaterialProcurementRequests = files.Length;
            if (cachedMaterialProcurementRequests == 1)
            {
                MaterialProcurementSchema cachedData = (MaterialProcurementSchema)JsonParser
                                                        .Deserialize<MaterialProcurementSchema>
                                                        (Path.Combine("Material Procured"
                                                                        , files[0].Name)
                                                        );
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
                UpdateUIAfterRequestingSample();
                FreezeFields();
            }
        }
    }
}
