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
    public partial class AcceptWarehouse : MaterialForm
    {
        public AcceptWarehouse()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            UpdateHint();
        }

        private void UpdateHint()
        {
            int warehousesAdded = ProcurementReceiveMaterialsUserControl.acceptedWarehouses.Count;
            if (ProcurementReceiveMaterialsUserControl.numberOfWarehouse > 1)
            {
                WarehouseControl.Hint = $"Warehouse {(warehousesAdded + 1)}";
            }
        }

        private void ProceedControl_Click(object sender, EventArgs e)
        {
            bool shouldProceed = ValidateWarehouse();
            if (!shouldProceed)
            {
                return;
            }

            shouldProceed = !CheckIfWarehouseExists(WarehouseControl.Text.Trim());
            if (!shouldProceed)
            {
                Utils.Utils.ShowMessageBox($"Warehouse {WarehouseControl.Text.Trim()} has already been added for this material", "Notice", MessageBoxButtons.OK);
                return;
            }
            bool alreadyAddedAWarehouse = ProcurementReceiveMaterialsUserControl.acceptedWarehouses.Count > 0;
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox($"Do you wish to proceed with {WarehouseControl.Text.Trim()} as part of your warehouse for receiving this material?\n\n" +
                                                    $"I'll {(alreadyAddedAWarehouse ? "also" : "")} keep this warehouse for you and show it when you're providing the various lots"
                                                    , "Confirm Proceed"
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question);
            if (userReponseToProceed == DialogResult.No)
            {
                return;
            }
            ProcurementReceiveMaterialsUserControl.acceptedWarehouses.Add(WarehouseControl.Text.Trim());
            Close();
        }

        private bool CheckIfWarehouseExists(string warehouseName)
        {
            List<string> items = ProcurementReceiveMaterialsUserControl.acceptedWarehouses;
            foreach (string item in items)
            {
                if (item.Contains(warehouseName))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidateWarehouse()
        {
            string warehouseCount = WarehouseControl.Text.Trim();
            if (warehouseCount.Length == 0)
            {
                Utils.Utils.ShowMessageBox("Kindly provide the warehouse the material would be kept"
                                                , "Error"
                                                , MessageBoxButtons.OK
                                                , MessageBoxIcon.Error);
                WarehouseControl.Focus();
                return false;
            }
            return true;
        }
    }
}
