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
    public partial class WareHouseRequest : MaterialForm
    {
        public WareHouseRequest()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
        }

        private void QuantityControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isHandled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
            e.Handled = isHandled;
        }

        private void ProceedControl_Click(object sender, EventArgs e)
        {
            int numberOfWarehouse = ValidateWarehouseCount();
            if (numberOfWarehouse == -1)
            {
                WarehouseCountControl.Focus();
                return;
            }
            DialogResult userReponseToProceed = Utils.Utils.ShowMessageBox($"Do you wish to proceed with {WarehouseCountControl.Text.Trim()} warehouse{(WarehouseCountControl.Text.Trim() == "1" ? "" : "s")}?\n\n" +
                                                            $"We'll prompt you shortly to provide the name{(numberOfWarehouse > 1 ? "s" : "")} for {(numberOfWarehouse == 1 ? "the warehouse" : $"all {numberOfWarehouse} warehouses")}"
                                                    , "Confirm Proceed"
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question);
            if (userReponseToProceed == DialogResult.No)
            {
                return;
            }
            ProcurementReceiveMaterialsUserControl.numberOfWarehouse = numberOfWarehouse;
            Close();
        }

        private int ValidateWarehouseCount()
        {
            string warehouseCount = WarehouseCountControl.Text.Trim();
            if (warehouseCount.Length == 0)
            {
                Utils.Utils.ShowMessageBox("Kindly provide the number of warehouses the material received would be kept"
                                                , "Error"
                                                , MessageBoxButtons.OK
                                                , MessageBoxIcon.Error);
                return -1;
            }
            int count;
            int.TryParse(WarehouseCountControl.Text.Trim(), out count);
            if (count <= 0)
            {
                Utils.Utils.ShowMessageBox("Kindly provide a valid number"
                                                , "Error"
                                                , MessageBoxButtons.OK
                                                , MessageBoxIcon.Error);
                return -1;
            }
            return count;
        }
    }
}
