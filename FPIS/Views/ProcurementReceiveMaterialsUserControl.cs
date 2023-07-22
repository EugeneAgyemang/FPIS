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
    public partial class ProcurementReceiveMaterialsUserControl : UserControl
    {
        private static ProcurementReceiveMaterialsUserControl instance;

        private int levelsPassed = 0;
        private bool userTriedToSave = false;

        public static List<string> acceptedWarehouses = new List<string>();
        public static List<string> acceptedLotsForWarehouses = new List<string>();
        public static List<Models.ProcurementLocation> procurementLocations = new List<Models.ProcurementLocation>();
        public static string unit;
        public static string productName;
        public static int numberOfWarehouse;

        public ProcurementReceiveMaterialsUserControl()
        {
            InitializeComponent();
            LoadMaterialsReceived();
        }

        private void LoadMaterialsReceived()
        {
            ViewPendingMaterials.DataSource = new ReceivingService(new()).FetchReceivedMaterialsPending();
            int newRequests = ViewPendingMaterials.Items.Count;
            if (newRequests == 0)
            {
                IncomingDetailsControl.Text = "No items at the moment";
                return;
            }
            IncomingDetailsControl.Text = ($"There {(newRequests == 1 ? "is" : "are")} {newRequests} new item{(newRequests == 1 ? "" : "s")} received");
        }

        private void QuantityControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isHandled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
            e.Handled = isHandled;
        }

        private void SaveProcurementRecords_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;
            shouldSave = PerformValidations();
            unit = UnitsControl.Text.Trim();

            if (!shouldSave)
            {
                return;
            }
            DialogResult userReponseToProceed = Utils.Utils
                                                    .ShowMessageBox("Do you wish to save the details provided?" 
                                                    , "Confirm Save"
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question);
            if (userReponseToProceed == DialogResult.No)
            {
                return;
            }
            productName = ViewPendingMaterials.Text;
            bool shouldContinue = GetLocationDetails();
            userTriedToSave = true;
            if (!shouldContinue)
            {
                return;
            }

            Receiving receivingRecord = UpdateMaterialReceivedRecord();
            if (receivingRecord == null)
            {
                return;
            }
            Models.ProcurementLocation firstLocation = SaveProcurementLocations(receivingRecord.Id);
            if (firstLocation != null)
            {
                ResetFields();
                ResetLotDetails();
                Utils.Utils.ShowMessageBox("Raw material received records has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool GetLocationDetails()
        {
            if (userTriedToSave)
            {
                CheckLevelsPassed(levelsPassed);
            }
            if (numberOfWarehouse == 0)
            {
                levelsPassed++;
                new WareHouseRequest().ShowDialog();
            }
            if (numberOfWarehouse == 0)
            {
                levelsPassed--;
                return false;
            }
            if (acceptedWarehouses.Count == 0)
            {
                levelsPassed++;
                for (int wareHousesAccepted = 1; wareHousesAccepted <= numberOfWarehouse; wareHousesAccepted++)
                {
                    new AcceptWarehouse().ShowDialog();
                    if (acceptedWarehouses.Count != wareHousesAccepted)
                    {
                        acceptedWarehouses.Clear();
                        levelsPassed--;
                        return false;
                    }
                }
            }
            if (acceptedLotsForWarehouses.Count == 0)
            {
                levelsPassed++;
                new LotRequest().ShowDialog();
            }
            if (acceptedLotsForWarehouses.Count == 0)
            {
                levelsPassed--;
                acceptedLotsForWarehouses.Clear();
                return false;
            }
            // Another way could be to check whether acceptedLotsForWarehouses was more than 0 which would mean
            // there would still be some lots to be provided. There isn't the need to clear procurement locations
            if (procurementLocations.Count < (procurementLocations.Count + GetNumberOfLotsRequiredToProceed()))
            {
                levelsPassed++;
                new AcceptLot().ShowDialog();
            }
            if (procurementLocations.Count < (procurementLocations.Count + GetNumberOfLotsRequiredToProceed()))
            {
                levelsPassed--;
                return false;
            }
            return true;
        }

        int GetNumberOfLotsRequiredToProceed()
        {
            int totalLotsRequired = 0;

            acceptedLotsForWarehouses.ForEach(acceptedLot =>
                        totalLotsRequired += ((int.Parse(acceptedLot.Split(">>")[1]) - int.Parse(acceptedLot.Split(">>")[2])) + 1)
                        );
            return totalLotsRequired;
        }

        private void CheckLevelsPassed(int levelsPassed)
        {
            string message = "Continue where you left off by providing";
            string[] instructions = {   "* The number of warehouses the materials would be kept",
                                        "* The names for the various warehouses the materials would be kept",
                                        "* The number of lots in each warehouse you'll keep the materails",
                                        "* The names of the various lots in the various warehouses the materials would be kept"};
            switch (levelsPassed)
            {
                case 0:
                    Utils.Utils.ShowMessageBox($"{message} the following details I'll be asking you:\n\n{instructions[0]}\n{instructions[1]}\n{instructions[2]}\n{instructions[3]}",
                                                "Note",
                                                MessageBoxButtons.OK);
                    break;
                case 1:
                    Utils.Utils.ShowMessageBox($"{message} the following details I'll be asking you:\n\n{instructions[1]}\n{instructions[2]}\n{instructions[3]}",
                                                "Note",
                                                MessageBoxButtons.OK);
                    break;
                case 2:
                    Utils.Utils.ShowMessageBox($"{message} the following details I'll be asking you:\n\n{instructions[2]}\n{instructions[3]}",
                                                "Note",
                                                MessageBoxButtons.OK);
                    break;
                case 3:
                    Utils.Utils.ShowMessageBox($"{message} the following details I'll be asking you:\n\n{instructions[3]}",
                                                "Note",
                                                MessageBoxButtons.OK);
                    break;
            }
        }

        private Receiving UpdateMaterialReceivedRecord()
        {
            Receiving receivedRecord = new ReceivingService(new()).FetchFirstPendingReceivedMaterial();
            if (receivedRecord == null)
            {
                return null;
            }
            receivedRecord.GrossWeight = GrossWeightControl.Text.Trim();
            receivedRecord.NetWeight = NetWeightControl.Text.Trim();
            receivedRecord.Units = UnitsControl.Text.Trim();
            receivedRecord.Quantity = CalculateOverallQuantity();
            receivedRecord = new ReceivingService(new()).UpdateRecord(receivedRecord);
            return receivedRecord;
        }

        private int CalculateOverallQuantity()
        {
            int quantity = 0;
            procurementLocations.ForEach(record => quantity += record.Quantity);
            return quantity;
        }

        private Models.ProcurementLocation SaveProcurementLocations(Guid materialReceivedId)
        {
            ApproxWeightsCalculator();
            Models.ProcurementLocation procurementLocation = null;
            procurementLocations.ForEach(record => record.ReceivingId = materialReceivedId);
            procurementLocation = new ProcurementLocationService(new()).SaveRecords(procurementLocations);
            return procurementLocation;
        }

        private void ApproxWeightsCalculator()
        {
            float approxWeightPerUnit = 0;

            approxWeightPerUnit = ApproxWeightPerUnitCalculator();
            procurementLocations.ForEach(record =>
                record.ApproxWeight = $"{approxWeightPerUnit * record.Quantity}"
            );
        }

        private float ApproxWeightPerUnitCalculator()
        {
            float approxWeights = 0;
            float netWeight = 0;
            int overallQuantity = 0;

            float.TryParse(NetWeightControl.Text, out netWeight);
            procurementLocations.ForEach(record =>
                overallQuantity += record.Quantity
            );
            approxWeights = netWeight / overallQuantity;

            return approxWeights;
        }

        public void ValidateFields(string unit
                                    , string gross
                                    , string net
                                    , ref bool shouldSave)
        {
            bool isErrorMessageDisplayed = false;
            ValidateUnit(unit, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateGrossWeight(gross, ref shouldSave, ref isErrorMessageDisplayed);
            ValidateNetWeight(net, ref shouldSave, ref isErrorMessageDisplayed);
        }

        public void ValidateUnit(string unit, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (unit.Length == 0)
            {
                DisplayErrorMessage(UnitsErrorCaption, ref shouldSave, ref isErrorMessageDisplayed, "I need the unit of measurement");
                return;
            }
        }

        public void ValidateGrossWeight(string grossWeight, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (grossWeight.Length == 0)
            {
                DisplayErrorMessage(GrossWeightErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the gross weight for the raw-material received");
                return;
            }
        }

        public void ValidateNetWeight(string netWeight, ref bool shouldSave, ref bool isErrorMessageDisplayed)
        {
            if (netWeight.Length == 0)
            {
                DisplayErrorMessage(NetWeightErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "I need the net weight for the raw-material received");
                return;
            }
            float net, gross;
            float.TryParse(NetWeightControl.Text.Trim(), out net);
            float.TryParse(GrossWeightControl.Text.Trim(), out gross);
            if (net >= gross)
            {
                DisplayErrorMessage(NetWeightErrorControl, ref shouldSave, ref isErrorMessageDisplayed, "Kindly provide the correct net weight");
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
            UnitsErrorCaption.Text =
            GrossWeightErrorControl.Text =
            NetWeightErrorControl.Text = string.Empty;
        }
        public void ResetFields()
        {
            UnitsControl.Text =
            NetWeightControl.Text =
            GrossWeightControl.Text = string.Empty;
            ReceivingSectionControl.Enabled =
                MaterialProcurementLastSection.Enabled = false;
            ViewPendingMaterials.DataSource = null;
            ViewPendingMaterials.Items.Remove(ViewPendingMaterials.SelectedItem);
            LoadMaterialsReceived();
            ViewPendingMaterials.StartIndex = -1;
        }

        private void ResetLotDetails()
        {
            acceptedWarehouses.Clear();
            acceptedLotsForWarehouses.Clear();
            procurementLocations.Clear();
            numberOfWarehouse = 0;
            unit = UnitsControl.Text.Trim();
            levelsPassed = 0;
        }

        private bool PerformValidations()
        {
            ResetErrorCaptions();
            bool shouldSave = true;
            bool isErrorMessageDisplayed = false;

            ValidateFields(UnitsControl.Text.Trim(),
                GrossWeightControl.Text.Trim(),
                NetWeightControl.Text.Trim(),
                ref shouldSave);

            return shouldSave;
        }

        private void FreezeFields()
        {
            MaterialProcurementLastSection.Enabled =
                ReceivingSectionControl.Enabled = false;
        }

        private void UnfreezeFields()
        {
            MaterialProcurementLastSection.Enabled =
                ReceivingSectionControl.Enabled = true;
        }

        private void SyncControl_Click(object sender, EventArgs e)
        {
            ResetLotDetails();
            ResetErrorCaptions();
            LoadMaterialsReceived();
        }

        private void ViewPendingMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ViewPendingMaterials.Text;

            if (selectedItem == string.Empty)
            {
                SaveProcurementRecords.Enabled = false;
                FreezeFields();
            }
            else
            {
                SaveProcurementRecords.Enabled = true;
                UnfreezeFields();
            }
        }
    }
}