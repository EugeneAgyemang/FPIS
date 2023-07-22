using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class LotRequest : MaterialForm
    {
        private List<string> wareHouses = new List<string>();
        public LotRequest()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            CopyListOfWarehouse();
            LotsCountErrorControl.ForeColor
                = WarehouseErrorControl.ForeColor
                = Color.Red;
        }

        private void CopyListOfWarehouse()
        {
            foreach (string warehouse in ProcurementReceiveMaterialsUserControl.acceptedWarehouses)
            {
                wareHouses.Add(warehouse);
            }
            WarehouseControl.DataSource = wareHouses;
            WarehouseControl.SelectedIndex = -1;
        }

        private void ProceedControl_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;
            int lotCount;

            shouldSave = PerformValidations();
            if (!shouldSave)
            {
                return;
            }
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox($"Do you wish to proceed by adding {LotsCountControl.Text.Trim()} lot{(LotsCountControl.Text.Trim() == "1" ? "" : "s")} to warehouse {WarehouseControl.Text.Trim()}?\n\n" +
                                                            $"We'll prompt you shortly to provide the name{(LotsCountControl.Text.Trim() == "1" ? "" : "s")} for {(LotsCountControl.Text.Trim() == "1"? "this lot" : $"all {LotsCountControl.Text.Trim()} lots")}"
                                                    , "Confirm Proceed"
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question);
            if (userReponseToProceed == DialogResult.No)
            {
                return;
            }
            int.TryParse(LotsCountControl.Text.Trim(), out lotCount);
            ProcurementReceiveMaterialsUserControl.acceptedLotsForWarehouses.Add($"{WarehouseControl.Text}>>{lotCount}>>1");
            wareHouses.Remove(WarehouseControl.Text);
            ResetFields();
            if (wareHouses.Count == 0)
            {
                Close();
            }
        }

        private void QuantityControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isHandled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
            e.Handled = isHandled;
        }

        private bool PerformValidations()
        {
            ResetErrorCaptions();
            bool shouldSave = true;

            ValidateFields(WarehouseControl.Text.Trim(),
                LotsCountControl.Text.Trim(),
                ref shouldSave);

            return shouldSave;
        }

        public void ValidateFields(string warehouse
                                    , string lots
                                    , ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateWarehouse(warehouse, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateLotCount(lots, ref shouldSave, ref isErrorMessageDisplayed);
        }

        public void ValidateLotCount(string lot, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (lot.Length == 0)
            {
                DisplayErrorMessage(LotsCountErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need a number for the lots");
                return;
            }
            int lotCount;
            int.TryParse(LotsCountControl.Text.Trim(), out lotCount);
            if (lotCount < 1)
            {
                DisplayErrorMessage(LotsCountErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "Kindly provide the correct number of lots");
                return;
            }
        }

        public void ValidateWarehouse(string warehouse, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (warehouse.Length == 0)
            {
                DisplayErrorMessage(WarehouseErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the warehouse so I can easily link up the lots");
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
            WarehouseErrorControl.Text =
            LotsCountErrorControl.Text = string.Empty;
        }

        public void ResetFields()
        {
            WarehouseControl.DataSource = null;
            WarehouseControl.Items.Clear();
            WarehouseControl.DataSource = wareHouses;
            LotsCountControl.Text = string.Empty;
            WarehouseControl.SelectedIndex = -1;
        }
    }
}
