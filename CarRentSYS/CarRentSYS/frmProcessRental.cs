using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Management.Instrumentation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarRentSYS
{
    public partial class frmProcessRental : Form
    {
        frmMainMenu parent;

        public frmProcessRental(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmProcessRental_Load(object sender, EventArgs e)
        {
            grdVehicles.DataSource = Reservation.GetTodaysPickedUpReservations();
            grdVehicles.CellDoubleClick += grdVehicles_CellContentClick;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (grdVehicles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdVehicles.SelectedRows[0];
                int resID = Convert.ToInt32(selectedRow.Cells["ResID"].Value);
                string license = txtDriverLicense.Text.Trim();

                if (Regex.IsMatch(license, "^[a-zA-Z0-9]{6,10}$"))
                {
                    Reservation.AddDriverLicense(resID, license);
                    Reservation.ChangeReservationStatusToPickedUp(resID);

                    MessageBox.Show("Driver's license added successfully and reservation status changed to 'Picked Up'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDriverLicense.Clear();

                    grdVehicles.DataSource = Reservation.GetTodaysPickedUpReservations();
                    grpResInfo.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please enter a valid Driver's License containing only letters and digits and 5-9 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
