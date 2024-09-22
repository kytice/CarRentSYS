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
    public partial class frmProcessReturn : Form
    {
        frmMainMenu parent;

        public frmProcessReturn(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmProcessReturn_Load(object sender, EventArgs e)
        {
            grdVehicles.DataSource = Reservation.GetReservationsWithPickedUpVehicles();
            grdVehicles.CellContentClick += grdVehicles_CellContentClick;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (grdVehicles.CurrentRow != null)
            {

                string resIDString = grdVehicles.CurrentRow.Cells["ResID"].Value.ToString();
                int resID = Convert.ToInt32(resIDString);

                Reservation.ProcessReturn(resID, DateTime.Today);
                MessageBox.Show("Payment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grpResInfo.Visible = false;
                grdVehicles.DataSource = Reservation.GetReservationsWithPickedUpVehicles();
            }
        }

        private void grdVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdVehicles.CurrentRow != null && grdVehicles.CurrentRow.DataBoundItem != null)
            {
                grpResInfo.Visible = true;

                string fname = grdVehicles.CurrentRow?.Cells["FName"].Value.ToString();
                string sname = grdVehicles.CurrentRow?.Cells["SName"].Value.ToString();
                string pickupDate = Convert.ToDateTime(grdVehicles.CurrentRow?.Cells["PickupDate"].Value).ToString("dd-MMM-yy");
                string returnDate = Convert.ToDateTime(grdVehicles.CurrentRow?.Cells["ReturnDate"].Value).ToString("dd-MMM-yy");
                string cost = grdVehicles.CurrentRow?.Cells["Cost"].Value.ToString();

                decimal initialCost = decimal.Parse(cost);
                DateTime returnDateTime = DateTime.Parse(returnDate);

                int delayDays = Math.Max((DateTime.Today - returnDateTime).Days, 0);
                decimal penalty = Reservation.CalculatePenalty(Convert.ToInt32(grdVehicles.CurrentRow?.Cells["ResID"].Value));
                decimal newCost = initialCost + penalty;

                string resInfo = $"Client: {fname} {sname}\n" +
                                 $"Pickup Date: {pickupDate}\n" +
                                 $"Return Date: {returnDate}\n" +
                                 $"Delay Days: {delayDays}\n";

                string costInfo = "";

                if (newCost != initialCost)
                {
                    costInfo =  $"Initial cost: {initialCost}\n" +
                                $"Penalty: {penalty}\n" +
                                $"New Cost: {newCost}\n";
                    lblCostInfo.ForeColor = Color.DarkRed;
                }
                else
                {
                    costInfo = $"Cost: {initialCost}\n";
                    lblCostInfo.ForeColor = SystemColors.ControlText;
                }

                lblResInfo.Text = resInfo;
                lblCostInfo.Text = costInfo;
            }
        }
    }
}
