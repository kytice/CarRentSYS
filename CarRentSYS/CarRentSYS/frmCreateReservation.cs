using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentSYS
{
    public partial class frmCreateReservation : Form
    {
        frmMainMenu parent;
        Reservation r = new Reservation();
        VehicleType selVehicleType; 
        int numberOfDays;

        public frmCreateReservation(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmCreateReservation_Load(object sender, EventArgs e)
        {
            calStartDate.MinDate = DateTime.Today;
            calStartDate.Value = DateTime.Today;

            calEndDate.MinDate = DateTime.Today;
            calEndDate.Value = DateTime.Today.AddDays(2);

            Utility.LoadTypesData(cboTypeCode);
            cboTypeCode.SelectedIndex = 0;
            grdVehicles.CellClick += grdVehicles_CellContentClick;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void ClearFields()
        {
            grdVehicles.Visible = false;
            lblTotalCost.Visible = false;
            grpResInfo.Visible = false;
            calEndDate.MinDate = DateTime.Today;
            calEndDate.Value = DateTime.Today.AddDays(2);
            cboTypeCode.SelectedIndex = 0;
            txtFName.Clear();
            txtSName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void grdVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdVehicles.Rows[e.RowIndex].DataBoundItem != null)
            {
                grpResInfo.Visible = true;
            }
            else
            {
                MessageBox.Show("Selected row is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateReservationDetails.IsReservationDetailsValid(txtFName.Text, txtSName.Text, txtEmail.Text, txtPhone.Text))
            {
                r.FName = txtFName.Text;
                r.SName = txtSName.Text;
                r.Email = txtEmail.Text;
                r.Phone = txtPhone.Text;
                r.RegNum = grdVehicles.CurrentRow?.Cells["RegNum"].Value.ToString();
                r.ResDate = DateTime.Now.Date;
                r.PickupDate = calStartDate.Value;
                r.ReturnDate = calEndDate.Value;
                r.Cost = r.CalculateCost(selVehicleType, numberOfDays);
                r.Status = 'R';
                
                r.CreateReservation();
                MessageBox.Show("Reservation created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                
            }
        }

        private void btnFindVehicles_Click(object sender, EventArgs e)
        {
            if (calStartDate.Value >= calEndDate.Value)
            {
                MessageBox.Show("Please select valid dates.");
                return;
            }

            string pickupDate = calStartDate.Value.ToString("dd-MMM-yy");
            string returnDate = calEndDate.Value.ToString("dd-MMM-yy");
            string selType = cboTypeCode.SelectedItem?.ToString()?.Split('-')[0]?.Trim();
            
            DataTable dt = Vehicle.GetAvailableVehiclesForType(selType, pickupDate, returnDate);

            if (dt.Rows.Count == 0)
                
            {
                MessageBox.Show("Sorry, no cars of that type available. Change dates or type", "No Cars Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                char trans = Convert.ToChar(row["Trans"]);
                char fuel = Convert.ToChar(row["Fuel"]);
                string transName = Utility.MapTransmission(trans);
                string fuelName = Utility.MapFuel(fuel);
                row["Trans"] = transName;
                row["Fuel"] = fuelName;
            }

            grdVehicles.DataSource = dt;

            selVehicleType = VehicleType.GetVehicleTypeByCode(selType); 
            numberOfDays = (calEndDate.Value - calStartDate.Value).Days;
            decimal totalCost = r.CalculateCost(selVehicleType, numberOfDays);
            lblTotalCost.Text = $"Total for {numberOfDays} days \nfor this type is €{totalCost}.";
            lblTotalCost.Visible = true;
            grdVehicles.Visible = true;
        }

    }
}
