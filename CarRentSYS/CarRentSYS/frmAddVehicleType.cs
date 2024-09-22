using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRentSYS
{

    public partial class frmAddVehicleType : Form
    {

        private frmMainMenu parent;

        public frmAddVehicleType(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void ClearFields()
        {
            txtTypeCode.Clear();
            txtName.Clear();
            txtDailyRate.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidateVehicleTypeData validator = new ValidateVehicleTypeData(txtTypeCode.Text, txtName.Text, txtDailyRate.Text);

            string validationMessage = validator.GetValidationMessage();

            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                decimal dailyRate = decimal.Parse(txtDailyRate.Text);
                VehicleType vehicleType = new VehicleType(txtTypeCode.Text, txtName.Text, dailyRate);
                vehicleType.AddVehicleType();
                MessageBox.Show("Vehicle Type added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
