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
    public partial class ProcurementLocation : MaterialForm
    {
        List<Models.ProcurementLocation> procurementLocations;
        int yAxis, gap = 88, locationsAvailable = 1;
        public ProcurementLocation(/*List<Models.ProcurementLocation> procurementLocations*/)
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            yAxis = LotOneControl.Location.Y + gap;
            //this.procurementLocations = procurementLocations;
        }

        private void AddLocationDetailsControl_Click(object sender, EventArgs e)
        {
            bool isMaterialsGoingToSameLocation = KeepWarehouseOneControl.Checked;
            bool shouldAddNewDetails = CheckWarehouseIsProvided();
            if (!shouldAddNewDetails)
            {
                return;
            }
            if (isMaterialsGoingToSameLocation)
            {
                AddLocationDetails(addNewWarehouse: false);
            }
            else
            {
                AddLocationDetails(addNewWarehouse: true);
            }
        }

        private void AddLocationDetails(bool addNewWarehouse)
        {
            int xAxisLot = 47, xAxisQuantity = 257;
            int width = 190, height = 50;
            MaterialTextBox lot = new MaterialTextBox();
            lot.Hint = $"Lot {++locationsAvailable} for warehouse";
            lot.Location = new Point(xAxisLot, yAxis);

            MaterialTextBox quantity = new MaterialTextBox();
            quantity.Hint = "Quantity to store";
            quantity.Location = new Point(xAxisQuantity, yAxis);

            quantity.Size = lot.Size = new Size(width, height);

            if (addNewWarehouse)
            {
                MaterialTextBox warehouse = new MaterialTextBox();
                warehouse.Size = new Size((width * 2 + (400 - (width * 2))), height);
                warehouse.Location = new Point(xAxisLot, yAxis);
                warehouse.Hint = $"Warehouse {locationsAvailable}";
                NewLocationsSection.Controls.Add(warehouse);

                lot.Location = new Point(xAxisLot, yAxis + gap);
                quantity.Location = new Point(xAxisQuantity, yAxis + gap);
                yAxis += gap;
            }
            NewLocationsSection.Controls.Add(lot);
            NewLocationsSection.Controls.Add(quantity);
            NewLocationsSection.Size = new Size(NewLocationsSection.Size.Width, NewLocationsSection.Size.Height + gap);
            if (Size.Height <= 500)
            {
                Size = new Size(Size.Width, Size.Height + gap);
            }
            yAxis += gap;
        }

        private bool CheckWarehouseIsProvided()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    foreach (Control childControl in control.Controls)
                    {
                        if (childControl.Name.Contains("Location"))
                        {
                            if (!IsDataProvided(childControl.Text))
                            {
                                childControl.Focus();
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        private bool IsDataProvided(string data)
        {
            if (!string.IsNullOrEmpty(data.Trim()))
            {
                return true;
            }
            Utils.Utils.ShowMessageBox("Kindly provide the warehouse", "Warehouse Needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
    }
}
