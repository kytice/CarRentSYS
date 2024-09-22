using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRentSYS
{
    public partial class frmAddVehicle : Form
    {
        frmMainMenu parent;

        public frmAddVehicle(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmAddVehicle_Load(object sender, EventArgs e)
        {
            Utility.LoadTypesData(cboTypeCode);
            Utility.LoadMakesData(cboMake);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModel.SelectedIndex = -1;
            string selMake = cboMake.SelectedItem?.ToString();
            Utility.LoadModelsData(cboModel, selMake);
        }

        private void ClearFields()
        {
            txtRegNum.Text = "";
            cboMake.SelectedIndex = -1;
            cboModel.SelectedIndex = -1;
            cboTypeCode.SelectedIndex = -1;
            cboTransmission.SelectedIndex = -1;
            cboFuel.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicle()
        {
            string regNum = txtRegNum.Text.Trim();
            string make = cboMake.Text.Trim();
            string model = cboModel.Text.Trim();
            string typeCode = (cboTypeCode.SelectedItem as string)?.Substring(0, 3) ?? "";
            char transmission = (cboTransmission.SelectedItem as string)?.Substring(0, 1)[0] ?? ' ';
            char fuel = (cboFuel.SelectedItem as string)?.Substring(0, 1)[0] ?? ' ';

            if (string.IsNullOrEmpty(regNum) ||
                string.IsNullOrEmpty(make) ||
                string.IsNullOrEmpty(model) ||
                string.IsNullOrEmpty(typeCode) ||
                transmission == ' ' ||
                fuel == ' ')
            {
                MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string regNumValidationMsg = ValidateVehicleData.IsValidRegNum(regNum);
            if (regNumValidationMsg != null)
            {
                MessageBox.Show(regNumValidationMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int modelID = Model.GetModelID(make, model);

            Vehicle vehicle = new Vehicle(regNum, modelID, typeCode, transmission, fuel);
            vehicle.AddVehicle(); 

            MessageBox.Show("Vehicle has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }
    }
}
