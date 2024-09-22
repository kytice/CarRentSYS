using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSYS
{
    public partial class frmCancelReservation : Form
    {

        frmMainMenu parent;

        public frmCancelReservation(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmCancelReservation_Load(object sender, EventArgs e)
        {
            grdVehicles.DataSource = Reservation.GetReservationsWithReservedVehicles();
            grdVehicles.CellDoubleClick += grdVehicles_CellContentClick;
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (grdVehicles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdVehicles.SelectedRows[0];
                int resID = Convert.ToInt32(selectedRow.Cells["ResID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to cancel the reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Reservation.CancelReservation(resID);
                    MessageBox.Show("Reservation is Cancelled", "Reservation Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpResInfo.Visible = false;
                    grdVehicles.DataSource = Reservation.GetReservationsWithReservedVehicles();
                    txtResID.Clear();
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string findResID = txtResID.Text.Trim();

            if (!string.IsNullOrEmpty(findResID))
            {
                bool found = false; 

                foreach (DataGridViewRow row in grdVehicles.Rows)
                {
                    if (row.Cells["ResID"] != null && row.Cells["ResID"].Value != null)
                    {
                        if (row.Cells["ResID"].Value.ToString() == findResID)
                        {
                            grdVehicles.CurrentCell = row.Cells[0];
                            grdVehicles.FirstDisplayedScrollingRowIndex = row.Index;

                            found = true;
                            break;
                        }
                    }
                }

                DataTable reservationDetails = Reservation.GetReservationsWithReservedVehicles();


                if (!found)
                {
                    MessageBox.Show("No active information found for the selected reservation id.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Please enter a reservation ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void grdVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtResID.Clear();
            if (e.RowIndex >= 0 && grdVehicles.Rows[e.RowIndex].DataBoundItem != null)
            {
                grpResInfo.Visible = true;

                string regNum = grdVehicles.CurrentRow?.Cells["RegNum"].Value.ToString();
                string fname = grdVehicles.CurrentRow?.Cells["FName"].Value.ToString();
                string sname = grdVehicles.CurrentRow?.Cells["SName"].Value.ToString();
                string make = grdVehicles.CurrentRow?.Cells["Make"].Value.ToString();
                string model = grdVehicles.CurrentRow?.Cells["Model"].Value.ToString();

                string resInfo = $"Client: {fname} {sname}\n\n" +
                    $"Vehicle: {make} {model}\n\n" +
                    $"RegNum: {regNum}";

                lblResInfo.Text = resInfo;
            }

            else
            {
                MessageBox.Show("Selected row is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
