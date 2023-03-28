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
        /// <summary>
        /// Toggle the switch for selecting the current date or a different date on or off. 
        /// We can easily use this function from elsewhere by setting the calledElseWhere
        /// to true.
        /// </summary>
        /// <param name="isCalledElsedWhere">Override the toggle feature when this value is given.
        /// It will just set the switch to the default state (Switched on). Extremely useful
        /// when the function is called outside the scope of the event on the switch itself.</param>
        private void ToggleSwitchDate(bool isCalledElsedWhere = false)
        {
            string[] captions = { "Use a new date", "Use today's date" };
            string[] switchDateCaptions = { "I'm using the current date", "I'm using the new date you pick" };
            string captionOfSwitchDateControl = SwitchDateControl.Text;
            if (captionOfSwitchDateControl == captions[1] || isCalledElsedWhere)
            {
                SwitchDateControl.Text = captions[0];
                SwitchDateCaptionControl.Text = switchDateCaptions[0];
                PickDateControl.Enabled = false;
                return;
            }
            SwitchDateControl.Text = captions[1];
            SwitchDateCaptionControl.Text = switchDateCaptions[1];
            PickDateControl.Enabled = true;
            PickDateControl.Value = DateTime.Now.Date;
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
            ResetErrorCaptions();
            bool shouldSave = true;
            ValidateFields(SupplierControl.Text.Trim(),
                TruckNumberControl.Text.Trim(),
                QuantityControl.Text.Trim(),
                UnitsControl.Text,
                ProductControl.Text,
                WarehouseControl.Text,
                ref shouldSave);

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
            Product selected = (Product)ProductControl.SelectedItem;
            Models.MaterialProcurement materialProcurement = new Models.MaterialProcurement()
            {
                ProductId = selected.Id,
                Location = WarehouseControl.Text.Trim(),
                Date = DateOnly.FromDateTime(PickDateControl.Value),
                Remarks = RemarksControl.Text.Trim(),
                Type = "Receiving",
                UserId = Guid.Parse(Main.LOGGED_USER_ID)
            };
            MaterialProcurementService materialProcurementService = new MaterialProcurementService(new());
            var materialProcured = materialProcurementService.SaveMaterialProcuredRecord(materialProcurement);
            SaveMaterialReceivedRecord(materialProcured.Id);
            return materialProcured;
        }
        private void SaveMaterialReceivedRecord(Guid materialBeingProcured)
        {
            int quantity;
            int.TryParse(QuantityControl.Text, out quantity);
            Receiving materialReceivedRecord = new Receiving()
            {
                Supplier = SupplierControl.Text.Trim(),
                TruckNumber = TruckNumberControl.Text.Trim(),
                Quantity = quantity,
                Units = UnitsControl.Text,
                MaterialProcurementId = materialBeingProcured
            };
            ReceivingService receivingService = new ReceivingService(new());
            receivingService.SaveMaterialReceivedRecord(materialReceivedRecord);
        }
        public void ValidateFields(string supplier, string truck, string quantity, string unit, string materialProcured, string warehouse, ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateSupplier(supplier, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateTruckNumber(truck, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateQuantity(quantity, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateUnit(unit, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateProduct(materialProcured, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateWarehouse(warehouse, ref shouldSave, ref isErrorMessageDisplayed);

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
                QuantityErrorCaption.Text =
                UnitsErrorCaption.Text =
                WarehouseErrorCaption.Text =
                ProductErrorCaption.Text = string.Empty;
        }
        public void ResetFields()
        {
            SupplierControl.Text =
                TruckNumberControl.Text =
                QuantityControl.Text =
                ProductControl.Text =
                RemarksControl.Text =
                string.Empty;
            ToggleSwitchDate(isCalledElsedWhere: true);
            ProductControl.StartIndex =
                UnitsControl.StartIndex =
                WarehouseControl.StartIndex = -1;
            RemarksCaptionControl.Text = $"Remarks ({500} characters)";
        }
    }
}
