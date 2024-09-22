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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuRates_Click(object sender, EventArgs e)
        {

        }

        private void mnuFleet_Click(object sender, EventArgs e)
        {

        }

        private void mnuAddVehicleType_Click(object sender, EventArgs e)
        {
            frmAddVehicleType newForm = new frmAddVehicleType(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuUpdateVehicleType_Click(object sender, EventArgs e)
        {
            frmUpdateVehicleType newForm = new frmUpdateVehicleType(this);
            this.Hide();
            newForm.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuAddVehicle_Click(object sender, EventArgs e)
        {
            frmAddVehicle newForm = new frmAddVehicle(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuCreateReservation_Click(object sender, EventArgs e)
        {
            frmCreateReservation newForm = new frmCreateReservation(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuCancelReservation_Click(object sender, EventArgs e)
        {
            frmCancelReservation newForm = new frmCancelReservation(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuProcessRental_Click(object sender, EventArgs e)
        {
            frmProcessRental newForm = new frmProcessRental(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuProcessReturn_Click(object sender, EventArgs e)
        {
            frmProcessReturn newForm = new frmProcessReturn(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuDiscontinueVehicle_Click(object sender, EventArgs e)
        {
            frmDiscontinueVehicle newForm = new frmDiscontinueVehicle(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuUpdateVehicle_Click(object sender, EventArgs e)
        {
            frmUpdateVehicle newForm = new frmUpdateVehicle(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuYearlyRevenueAnalysis_Click(object sender, EventArgs e)
        {
            frmYearlyRevenueAnalysis newForm = new frmYearlyRevenueAnalysis(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuYearlyCarTypeAnalysis_Click(object sender, EventArgs e)
        {
            frmYearlyVehicleTypeAnalysis newForm = new frmYearlyVehicleTypeAnalysis(this);
            this.Hide();
            newForm.Show();
        }
    }
}
