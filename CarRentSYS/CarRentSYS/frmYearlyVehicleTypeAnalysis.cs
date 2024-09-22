using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CarRentSYS
{
    public partial class frmYearlyVehicleTypeAnalysis : Form
    {
        private frmMainMenu parent;

        public frmYearlyVehicleTypeAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex != -1)
            {
                int year = Convert.ToInt32(cboYear.SelectedItem);
                GenerateReport(year);
            }
        }

        private void GenerateReport(int year)
        {
            DataSet ds = Reservation.GetYearlyVehicleTypeData(year);

            DataTable dt = ds.Tables[0];

            string[] vehicleTypes = new string[dt.Rows.Count];
            int[] reservationCounts = new int[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                vehicleTypes[i] = dt.Rows[i]["Name"].ToString();
                reservationCounts[i] = Convert.ToInt32(dt.Rows[i]["ReservationCount"]);
            }

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series.Clear();
            chtData.Series.Add("ReservationCount");
            chtData.Series["ReservationCount"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chtData.Series["ReservationCount"].Points.DataBindXY(vehicleTypes, reservationCounts);
            chtData.Titles.Clear();
            chtData.Titles.Add($"Yearly Vehicle Type Analysis");
        }

        private void frmYearlyVehicleTypeAnalysis_Load(object sender, EventArgs e)
        {
            DataSet ds = Reservation.GetReservationYears();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboYear.Items.Add(ds.Tables[0].Rows[i][0]);
            }

            cboYear.SelectedIndex = 0;
        }
    }
}
