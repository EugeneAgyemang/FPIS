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
    public partial class MaterialProcurement : UserControl
    {
        private static MaterialProcurement instance;
        private MaterialProcurement()
        {
            InitializeComponent();
            SelectedDateControl.Text = GetDate(DateFormat.DATE_ONLY, DateTime.Now);
            LoadProductNames();
        }

        public static MaterialProcurement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MaterialProcurement();
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
            string[] captions = { "Use a new date", "Use today's date" };
            string[] switchDateCaptions = { "I'm using the current date", "I'm using the new date you pick" };
            string captionOfSwitchDateControl = SwitchDateControl.Text;
            if (captionOfSwitchDateControl == captions[0])
            {
                SwitchDateControl.Text = captions[1];
                SwitchDateCaptionControl.Text = switchDateCaptions[1];
                PickDateControl.Enabled = true;
                return;
            }
            SwitchDateControl.Text = captions[0];
            SwitchDateCaptionControl.Text = switchDateCaptions[0];
            PickDateControl.Enabled = false;
            PickDateControl.Value = DateTime.Now;
        }

        private void PickDateControl_ValueChanged(object sender, EventArgs e)
        {
            DateTime datePicked = PickDateControl.Value;
            SelectedDateControl.Text = GetDate(DateFormat.DATE_ONLY, datePicked);
        }

        private void QuantityControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isHandled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
            e.Handled = isHandled;
        }
        private void LoadProductNames()
        {
            MaterialProcurementService materialProcurementService = new MaterialProcurementService(new());
            var products = materialProcurementService.LoadProducts();
            foreach (Product product in products)
            {
                ProductControl.Items.Add(product);
            }
        }
        private void SaveProcurementRecords_Click(object sender, EventArgs e)
        {
            SaveMaterialProcuredRecord();
        }
        private void SaveMaterialProcuredRecord()
        {
            Product selected = (Product)ProductControl.SelectedItem;
            Models.MaterialProcurement materialProcurement = new Models.MaterialProcurement()
            {
                ProductId = selected.Id,
                Location = WarehouseControl.Text,
                Date = DateOnly.FromDateTime(PickDateControl.Value),
                Remarks = RemarksControl.Text,
                Type = "Receiving",
                UserId = Guid.Parse("ba491ba1-1f50-462d-965d-cd568472bcf1")
            };
            MaterialProcurementService materialProcurementService = new MaterialProcurementService(new());
            var materialProcured = materialProcurementService.SaveMaterialProcuredRecord(materialProcurement);
            SaveMaterialReceivedRecord(materialProcured.Id);
        }
        private void SaveMaterialReceivedRecord(Guid materialBeingProcured)
        {
            int quantity;
            int.TryParse(QuantityControl.Text, out quantity);
            Receiving materialReceivedRecord = new Receiving()
            {
                Supplier = SupplierControl.Text,
                TruckNumber = TruckNumberControl.Text,
                Quantity = quantity,
                Units = UnitsControl.Text,
                MaterialProcurementId = materialBeingProcured
            };
            MaterialProcurementService materialProcurementService = new MaterialProcurementService(new());
            materialProcurementService.SaveMaterialReceivedRecord(materialReceivedRecord);
        }
    }
}
