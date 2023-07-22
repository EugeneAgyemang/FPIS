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
    public partial class AcceptLot : MaterialForm
    {
        public AcceptLot()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            WarehouseControl.DataSource = ProcurementReceiveMaterialsUserControl.acceptedWarehouses;
            WarehouseControl.SelectedIndex = -1;
            LotsErrorControl.ForeColor
                = WarehouseErrorControl.ForeColor
                = QuantityErrorControl.ForeColor
                = Color.Red;
        }

        private void QuantityControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isHandled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
            e.Handled = isHandled;
        }

        private void ProceedControl_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;
            string unit, productName;
            int quantity;

            shouldSave = PerformValidations();
            if (!shouldSave)
            {
                return;
            }
            shouldSave = !CheckIfLotExists(LotControl.Text.Trim());
            if (!shouldSave)
            {
                Utils.Utils.ShowMessageBox($"Lot {LotControl.Text.Trim()} has already been added for warehouse {WarehouseControl.Text}", "Notice", MessageBoxButtons.OK);
                return;
            }
            unit = ProcurementReceiveMaterialsUserControl.unit;
            productName = ProcurementReceiveMaterialsUserControl.productName;
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox($"Do you wish to proceed by receiving {QuantityControl.Text.Trim()} {unit} into warehouse {WarehouseControl.Text.Trim()}, lot {LotControl.Text.Trim()}?"
                                                    , "Confirm Proceed"
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question);
            if (userReponseToProceed == DialogResult.No)
            {
                return;
            }
            int.TryParse(QuantityControl.Text.Trim(), out quantity);
            ProcurementReceiveMaterialsUserControl.procurementLocations.Add(new Models.ProcurementLocation()
            {
                Location = WarehouseControl.Text.Trim(),
                Lot = LotControl.Text.Trim(),
                Quantity = quantity
            });
            UpdateLotAdded(WarehouseControl.Text.Trim());
            ResetFields();
            if (ProcurementReceiveMaterialsUserControl.acceptedWarehouses.Count == 0)
            {
                int overallQuantity = 0;
                int countOfLots = 0;
                foreach(Models.ProcurementLocation procurementLocation in ProcurementReceiveMaterialsUserControl.procurementLocations)
                {
                    overallQuantity += procurementLocation.Quantity;
                    countOfLots++;
                }
                Utils.Utils.ShowMessageBox($"{overallQuantity} {unit} of {productName} would be stored in {(countOfLots == 1? "a lot" : $"{countOfLots} different lots")}"
                , "Note", MessageBoxButtons.OK);
                Close();
            }
        }

        private bool CheckIfLotExists(string lot)
        {
            List<string> items = ProcurementReceiveMaterialsUserControl.acceptedLotsForWarehouses;
            List<Models.ProcurementLocation> procurementLocations = ProcurementReceiveMaterialsUserControl.procurementLocations;
            string warehouse;
            foreach (string item in items)
            {
                warehouse = item.Split(">>")[0];
                if (warehouse != WarehouseControl.Text)
                {
                    continue;
                }
                foreach (Models.ProcurementLocation procurementLocation in procurementLocations)
                {
                    if (warehouse == procurementLocation.Location && procurementLocation.Lot == lot)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private string GetLotForSelectedWarehouse(string selectedWarehouse)
        {
            string selectedWarehouseWithLots = "";
            int lotsLeft;
            List<string> acceptedItems = ProcurementReceiveMaterialsUserControl.acceptedLotsForWarehouses;
            foreach (string acceptedItem in acceptedItems)
            {
                if (acceptedItem.Contains(selectedWarehouse))
                {
                    int.TryParse(acceptedItem.Split(">>")[2], out lotsLeft);
                    selectedWarehouseWithLots = acceptedItem;
                    LotControl.Hint = $"Lot {lotsLeft} of {acceptedItem.Split(">>")[1]}";
                    break;
                }
            }
            return selectedWarehouseWithLots;
        }

        private void UpdateLotAdded(string selectedWarehouse)
        {
            int lotUsed;
            string selectedLot = GetLotForSelectedWarehouse(selectedWarehouse);
            int.TryParse(selectedLot.Split(">>")[2], out lotUsed);
            string[] tokens = selectedLot.Split(">>");
            tokens[2] = $"{++lotUsed}";
            UpdateLotUsed(tokens);
        }

        private void UpdateLotUsed(string[] tokens)
        {
            string formatted = string.Join(">>", tokens);
            int index = 0;
            List<string> acceptedItems = ProcurementReceiveMaterialsUserControl.acceptedLotsForWarehouses;
            string[] acceptedItemsTmp = new string[acceptedItems.Count];
            acceptedItems.CopyTo(acceptedItemsTmp);
            foreach (string acceptedItem in acceptedItemsTmp)
            {
                if (acceptedItem.Contains(tokens[0]))
                {
                    ProcurementReceiveMaterialsUserControl.acceptedLotsForWarehouses[index] = formatted;
                    break;
                }
                index++;
            }
            RemoveWarehouse();
        }

        private void RemoveWarehouse()
        {
            List<string> acceptedItems = ProcurementReceiveMaterialsUserControl.acceptedLotsForWarehouses;
            foreach (string acceptedItem in acceptedItems)
            {
                int lotsUsed;
                int lotsFree;

                int.TryParse(acceptedItem.Split(">>")[2], out lotsUsed);
                int.TryParse(acceptedItem.Split(">>")[1], out lotsFree);
                if (lotsUsed > lotsFree)
                {
                    ProcurementReceiveMaterialsUserControl.acceptedLotsForWarehouses.Remove(acceptedItem);
                    ProcurementReceiveMaterialsUserControl.acceptedWarehouses.Remove(acceptedItem.Split(">>")[0]);
                    WarehouseControl.DataSource = null;
                    WarehouseControl.Items.Clear();
                    WarehouseControl.DataSource = ProcurementReceiveMaterialsUserControl.acceptedWarehouses;
                    break;
                }
            }
        }

        private bool PerformValidations()
        {
            ResetErrorCaptions();
            bool shouldSave = true;

            ValidateFields(WarehouseControl.Text.Trim(),
                LotControl.Text.Trim(),
                QuantityControl.Text.Trim(),
                ref shouldSave);

            return shouldSave;
        }

        public void ValidateFields(string warehouse
                                    , string lots
                                    , string quantity
                                    , ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateWarehouse(warehouse, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateLot(lots, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateQuantity(quantity, ref shouldSave, ref isErrorMessageDisplayed);
        }

        public void ValidateLot(string lot, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (lot.Length == 0)
            {
                DisplayErrorMessage(LotsErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the lot name");
                return;
            }
        }

        public void ValidateWarehouse(string warehouse, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (warehouse.Length == 0)
            {
                DisplayErrorMessage(WarehouseErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the warehouse for the lot");
                return;
            }
        }

        public void ValidateQuantity(string quantity, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (quantity.Length == 0)
            {
                DisplayErrorMessage(QuantityErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the quantity received into this lot");
                return;
            }
            int lotCount;
            int.TryParse(QuantityControl.Text.Trim(), out lotCount);
            if (lotCount < 1)
            {
                DisplayErrorMessage(QuantityErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "Kindly provide a valid quantity");
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
            LotsErrorControl.Text =
            QuantityErrorControl.Text = string.Empty;
        }

        public void ResetFields()
        {
            WarehouseControl.DataSource = null;
            WarehouseControl.Items.Clear();
            WarehouseControl.DataSource = ProcurementReceiveMaterialsUserControl.acceptedWarehouses;
            LotControl.Text =
                QuantityControl.Text = string.Empty;
            WarehouseControl.SelectedIndex = -1;
            LotControl.Hint = "Lot";
        }

        private void WarehouseControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string warehouseSelected = WarehouseControl.Text.Trim();
            GetLotForSelectedWarehouse(warehouseSelected);
        }
    }
}
