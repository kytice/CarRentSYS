                                                    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSYS
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        private frmMainMenu parent;
        public frmYearlyRevenueAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            DataSet ds = Reservation.GetReservationYears();
            Console.WriteLine("Number of rows in dataset: " + ds.Tables[0].Rows.Count);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboYear.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            cboYear.SelectedIndex = 0;

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
            DataSet ds = Reservation.GetYearlyRevenueData(year);

            DataTable dt = ds.Tables[0];

            String[] Months = new string[12];
            Decimal[] Amounts = new Decimal[12];

            for (int i = 0; i < 12; i++)
            {
                Months[i] = GetMonthName(i + 1);
                Amounts[i] = 0;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Amounts[Convert.ToInt32(dt.Rows[i][0]) - 1] = Convert.ToDecimal(dt.Rows[i][1]);
            }

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";
            chtData.Series[0].Points.DataBindXY(Months, Amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtData.Series[0].Label = "#VALY";
            chtData.Titles.Clear();
            chtData.Titles.Add($"Yearly Revenue");
        }

        private string GetMonthName(int month)
        {
            switch (month)
            {
                case 1: return "JAN";
                case 2: return "FEB";
                case 3: return "MAR";
                case 4: return "APR";
                case 5: return "MAY";
                case 6: return "JUN";
                case 7: return "JUL";
                case 8: return "AUG";
                case 9: return "SEP";
                case 10: return "OCT";
                case 11: return "NOV";
                case 12: return "DEC";
                default: return "OTH";
            }
        }
    }
}
