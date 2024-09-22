using System;
using System.Windows.Forms;

namespace CarRentSYS
{
    public partial class frmUpdateVehicleType : Form
    {
        private frmMainMenu parent;

        public frmUpdateVehicleType(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateVehicleType_Load(object sender, EventArgs e)
        {
            Utility.LoadTypesData(cboTypeCode);
            cboTypeCode.SelectedIndex = 0;
        }

        private string GetSelectedTypeCode()
        {
            return cboTypeCode.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selTypeCode = GetSelectedTypeCode();

            ValidateVehicleTypeData validator = new ValidateVehicleTypeData(txtName.Text, txtDailyRate.Text);

            string validationMessage = validator.GetValidationMessage();

            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VehicleType existingTypeCode = VehicleType.GetVehicleTypeByCode(selTypeCode);

            VehicleType vehicleTypeToUpdate = new VehicleType(existingTypeCode.TypeCode, txtName.Text, Convert.ToDecimal(txtDailyRate.Text));
            vehicleTypeToUpdate.UpdateVehicleType();

            MessageBox.Show("Vehicle Type is updated in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Utility.LoadTypesData(cboTypeCode);
            cboTypeCode.SelectedIndex = 0;
            grpUpdateVehicleType.Visible = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            grpUpdateVehicleType.Visible = true;
            string selTypeCode = GetSelectedTypeCode();
            VehicleType vehicleType = VehicleType.GetVehicleTypeByCode(selTypeCode);
            txtName.Text = vehicleType.Name;
            txtDailyRate.Text = vehicleType.DailyRate.ToString();
        }
    }
}
