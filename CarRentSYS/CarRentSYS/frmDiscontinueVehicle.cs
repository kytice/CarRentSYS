using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarRentSYS
{
    public partial class frmDiscontinueVehicle : Form
    {
        frmMainMenu parent;

        public frmDiscontinueVehicle(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmDiscontinueVehicle_Load(object sender, EventArgs e)
        {
            DataTable vehiclesTable = Vehicle.GetAllAvailableVehicles();
            grdVehicles.DataSource = vehiclesTable;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnDiscontinue_Click(object sender, EventArgs e)
        {
            if (grdVehicles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdVehicles.SelectedRows[0];
                DataGridViewCell regNumCell = selectedRow.Cells["RegNum"];

                if (regNumCell.Value != null)
                {
                    string regNum = regNumCell.Value.ToString();

                    if (Vehicle.HasReservedOrPickedUpReservations(regNum))
                    {
                        MessageBox.Show("Cannot discontinue the vehicle because there are reservations with status Reserved or Picked Up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DiscontinueVehicle(regNum);
                }
                else
                {
                    MessageBox.Show("The selected vehicle's registration number is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DiscontinueVehicle(string regNum)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discontinue this vehicle? This action cannot be undone.", "Confirm Discontinuation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.DiscontinueVehicle(regNum);
                
                MessageBox.Show("Vehicle discontinued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdVehicles.DataSource = Vehicle.GetAllAvailableVehicles();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchRegNum = txtRegNumSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchRegNum))
            {
                bool found = false; 

                foreach (DataGridViewRow row in grdVehicles.Rows)
                {
                    if (row.Cells["RegNum"] != null && row.Cells["RegNum"].Value != null)
                    {
                        if (row.Cells["RegNum"].Value.ToString() == searchRegNum)
                        {
                            grdVehicles.CurrentCell = row.Cells[0];
                            grdVehicles.FirstDisplayedScrollingRowIndex = row.Index;

                            found = true;
                            break;
                        }
                    }
                }

                DataTable vehicleDetails = Vehicle.GetVehicleDetails(searchRegNum);

                if (!found)
                {
                    MessageBox.Show("No active information found for the selected registration number. The vehicle may be discontinued or does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Please enter a registration number to search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRegNumSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
