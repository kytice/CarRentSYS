using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentSYS
{
    public partial class frmUpdateVehicle : Form
    {
        frmMainMenu parent;

        public frmUpdateVehicle(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateVehicle_Load(object sender, EventArgs e)
        {
            Utility.LoadTypesData(cboTypeCode);
            Utility.LoadMakesData(cboMake);

            LoadDataIntoGrid();
            grdVehicles.CellContentClick += grdVehicles_CellContentClick;
        }

        private void LoadDataIntoGrid()
        {
            DataTable dt = Vehicle.GetAllAvailableVehicles();
            foreach (DataRow row in dt.Rows)
            {
                char trans = Convert.ToChar(row["Trans"]);
                char fuel = Convert.ToChar(row["Fuel"]);

                string transmissionName = Utility.MapTransmission(trans);
                string fuelName = Utility.MapFuel(fuel);

                row["Trans"] = transmissionName;
                row["Fuel"] = fuelName;
            }
            grdVehicles.DataSource = dt;
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModel.SelectedIndex = -1;
            string selMake = cboMake.SelectedItem?.ToString();
            Utility.LoadModelsData(cboModel, selMake);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateVehicle();
        }

        private void UpdateVehicle()
        {
            string regNum = txtRegNum.Text.Trim();
            string make = cboMake.Text.Trim();
            string model = cboModel.Text.Trim();
            string typeCode = (cboTypeCode.SelectedItem as string)?.Substring(0, 3) ?? "";
            char transmission = (cboTransmission.SelectedItem as string)?.Substring(0, 1)[0] ?? ' ';
            char fuel = (cboFuel.SelectedItem as string)?.Substring(0, 1)[0] ?? ' ';

            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int modelID = Model.GetModelID(make, model);

            Vehicle vehicle = new Vehicle(regNum, modelID, typeCode, transmission, fuel);
            vehicle.UpdateVehicle();

            MessageBox.Show("Vehicle updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataIntoGrid();
            grpUpdateVehicle.Visible = false;
            txtRegNumSearch.Clear();
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

        private void ViewVehicleDetails(DataRow dr)
        {
            grpUpdateVehicle.Visible = true;

            txtRegNum.Text = dr["RegNum"].ToString();
            cboMake.SelectedItem = dr["Make"].ToString();
            cboModel.SelectedItem = dr["Model"].ToString();

            Utility.LoadTypesData(cboTypeCode);
            string typeCodeToSelect = dr["TypeCode"].ToString();

            for (int i = 0; i < cboTypeCode.Items.Count; i++)
            {
                if (cboTypeCode.Items[i].ToString().StartsWith(typeCodeToSelect + " - "))
                {
                    cboTypeCode.SelectedIndex = i;
                    break;
                }
            }

            char trans = Convert.ToChar(dr["Trans"].ToString());
            cboTransmission.SelectedItem = Utility.MapTransmission(trans);
            char fuel = Convert.ToChar(dr["Fuel"].ToString());
            cboFuel.SelectedItem = Utility.MapFuel(fuel);
        }

        private void grdVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = grdVehicles.Rows[e.RowIndex];
                string regNum = selectedRow.Cells["RegNum"].Value.ToString();
                DataTable vehicleDetails = Vehicle.GetVehicleDetails(regNum);
                ViewVehicleDetails(vehicleDetails.Rows[0]);
                txtRegNumSearch.Clear();
            }
        }
    }
}
