using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentSYS
{
    class Reservation
    {
        private int _resID;
        private string _fName;
        private string _sName;
        private string _email;
        private string _phone;
        private string _regNum;
        private DateTime _resDate;
        private DateTime _pickupDate;
        private DateTime _returnDate;
        private DateTime _actReturnDate;
        private decimal _cost;
        private char _status;

        public int ResID
        {
            get { return _resID; }
            private set { _resID = value; }
        }

        public string FName
        {
            get { return _fName; }
            set { _fName = Utility.FormatName(value); }
        }

        public string SName
        {
            get { return _sName; }
            set { _sName = Utility.FormatName(value); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value.ToLower(); }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string RegNum
        {
            get { return _regNum; }
            set { _regNum = value; }
        }

        public DateTime ResDate
        {
            get { return _resDate; }
            set { _resDate = value; } 
        }

        public DateTime PickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; }
        }

        public DateTime ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        public DateTime ActReturnDate
        {
            get { return _actReturnDate; }
            set { _actReturnDate = value; }
        }

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public char Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Reservation()
        {
            _resID = 0;
            _fName = "";
            _sName = "";
            _email = "";
            _phone = "";
            _regNum = "";
            _resDate = DateTime.Now.Date;
            _pickupDate = DateTime.Today;
            _returnDate = DateTime.Today;
            _cost = 0;
            _status = 'R';
        }

        public static int GetNextResID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string sqlQuery = "SELECT MAX(ResID) FROM Reservations";

            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                conn.Open();

                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read() && !dr.IsDBNull(0))
                    {
                        return dr.GetInt32(0) + 1;
                    }
                }
            }

            return 1; // Return 1 if there are no reservations
        }

        public decimal CalculateCost(VehicleType vehicleType, int numberOfDays)
        {
            return vehicleType.DailyRate * numberOfDays;
        }

        public void CreateReservation()
        {
            int nextResID = GetNextResID();

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "INSERT INTO Reservations (ResID, FName, SName, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status) " +
                                  "VALUES (:ResID, :FName, :SName, :Email, :Phone, :RegNum, :ResDate, :PickupDate, :ReturnDate, :Cost, :Status)";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("ResID", nextResID);
                    cmd.Parameters.Add("FName", _fName);
                    cmd.Parameters.Add("SName", _sName);
                    cmd.Parameters.Add("Email", _email);
                    cmd.Parameters.Add("Phone", _phone);
                    cmd.Parameters.Add("RegNum", _regNum);
                    cmd.Parameters.Add("ResDate", _resDate);
                    cmd.Parameters.Add("PickupDate", _pickupDate);
                    cmd.Parameters.Add("ReturnDate", _returnDate);
                    cmd.Parameters.Add("Cost", OracleDbType.Decimal).Value = _cost; 
                    cmd.Parameters.Add("Status", _status);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static void CancelReservation(int resID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "UPDATE Reservations SET Status = 'C' WHERE ResID = :ResID";
                try
                {
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))

                    {
                        cmd.Parameters.Add(":ResID", OracleDbType.Int32).Value = resID;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static DataTable GetTodaysPickedUpReservations()
        {
            DataTable dt = new DataTable();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
                {
                    conn.Open();

                    string sqlQuery = "SELECT r.ResID, r.FName, r.SName, m.Make, m.Model, r.RegNum, r.Email, r.Phone, r.ResDate, r.PickupDate, r.ReturnDate, r.Cost " +
                                    "FROM Reservations r " +
                                    "INNER JOIN Vehicles v ON r.RegNum = v.RegNum " +
                                    "INNER JOIN Models m ON v.ModelID = m.ModelID " +
                                    "WHERE r.Status = 'R' AND TRUNC(r.PickupDate) = TRUNC(SYSDATE) " +
                                    "ORDER BY r.SName, r.FName";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }



        public static DataTable GetReservationsWithReservedVehicles()
        {
            DataTable dt = new DataTable();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
                {
                    conn.Open();

                    string sqlQuery = "SELECT r.ResID, r.FName, r.SName, m.Make, m.Model, r.RegNum, r.Email, r.Phone, r.ResDate, r.PickupDate, r.ReturnDate, r.Cost " +
                                    "FROM Reservations r " +
                                    "INNER JOIN Vehicles v ON r.RegNum = v.RegNum " +
                                    "INNER JOIN Models m ON v.ModelID = m.ModelID " +
                                    "WHERE r.Status = 'R' " +
                                    "ORDER BY r.PickupDate";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }


        public static DataTable GetReservationsWithPickedUpVehicles()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
                {
                    conn.Open();

                    string sqlQuery = "SELECT r.ResID, r.FName, r.SName, m.Make, m.Model, v.RegNum, r.License, r.Email, r.Phone, r.ResDate, r.PickupDate, r.ReturnDate, r.Cost, ra.DailyRate " +
                                    "FROM Reservations r " +
                                    "INNER JOIN Vehicles v ON r.RegNum = v.RegNum " +
                                    "INNER JOIN Models m ON v.ModelID = m.ModelID " +
                                    "INNER JOIN Rates ra ON v.TypeCode = ra.TypeCode " +
                                    "WHERE r.Status = 'P' " +
                                    "ORDER BY r.PickupDate";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }



        public static void AddDriverLicense(int resID, string license)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "UPDATE Reservations SET License = :License WHERE ResID = :ResID";

                try
                {
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                    
                        cmd.Parameters.Add(":License", OracleDbType.Varchar2).Value = license;
                        cmd.Parameters.Add(":ResID", OracleDbType.Int32).Value = resID;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void ChangeReservationStatusToPickedUp(int resID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "UPDATE Reservations SET Status = 'P' WHERE ResID = :ResID";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":ResID", OracleDbType.Int32).Value = resID;
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
        }
        public static decimal CalculatePenalty(int resID)
        {
            decimal penalty = 0;

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT ReturnDate, CURRENT_DATE AS ActReturnDate, v.TypeCode, ra.DailyRate " +
                                  "FROM Reservations r " +
                                  "INNER JOIN Vehicles v ON r.RegNum = v.RegNum " +
                                  "INNER JOIN Rates ra ON v.TypeCode = ra.TypeCode " +
                                  "WHERE ResID = :ResID";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":ResID", OracleDbType.Int32).Value = resID;

                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime returnDate = reader.GetDateTime(reader.GetOrdinal("ReturnDate"));
                            DateTime actReturnDate = reader.GetDateTime(reader.GetOrdinal("ActReturnDate"));
                            string typeCode = reader.GetString(reader.GetOrdinal("TypeCode"));
                            decimal dailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate"));

                            if (actReturnDate > returnDate)
                            {
                                int daysDifference = (int)(actReturnDate - returnDate).TotalDays;
                                penalty = daysDifference * 2 * dailyRate;
                            }
                        }
                    }
                }
            }

            return penalty;
        }


        public static void ProcessReturn(int resID, DateTime actReturnDate)
        {
            decimal penalty = CalculatePenalty(resID); 

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "UPDATE Reservations " +
                                  "SET ActReturnDate = :ActReturnDate, Cost = Cost + :Penalty, Status = 'D' " +
                                  "WHERE ResID = :ResID";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":ActReturnDate", OracleDbType.Date).Value = actReturnDate;
                    cmd.Parameters.Add(":Penalty", OracleDbType.Double).Value = penalty;
                    cmd.Parameters.Add(":ResID", OracleDbType.Int32).Value = resID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static DataSet GetReservationYears()
        {
            DataSet ds = new DataSet();

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                string sqlQuery = "SELECT DISTINCT EXTRACT(YEAR FROM ActReturnDate) AS ReservationYear " +
                                  "FROM Reservations " +
                                  "WHERE Status = 'D' AND ActReturnDate IS NOT NULL";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
            }

            return ds;
        }


        public static DataSet GetYearlyRevenueData(int year)
        {
            string sqlQuery = "SELECT TO_CHAR(ActReturnDate, 'MM'), SUM(Cost) " +
                            "FROM Reservations " +
                            "WHERE TO_CHAR(ActReturnDate, 'YYYY') = :Year AND Status = 'D' " +
                            "GROUP BY TO_CHAR(ActReturnDate, 'MM')";

            DataSet ds = new DataSet();

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add(":Year", OracleDbType.Varchar2).Value = year.ToString();

                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }

            return ds;
        }

        public static DataSet GetYearlyVehicleTypeData(int year)
        {
            string sqlQuery = "SELECT v.TypeCode, t.Name, COUNT(*) as ReservationCount " +
                             "FROM Reservations r " +
                             "INNER JOIN Vehicles v ON r.RegNum = v.RegNum " +
                             "INNER JOIN Rates t ON v.TypeCode = t.TypeCode " +
                             "WHERE TO_CHAR(r.ResDate, 'YYYY') = :Year AND Status = 'D' " +
                             "GROUP BY v.TypeCode, t.Name";

            DataSet ds = new DataSet();

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add(":Year", OracleDbType.Varchar2).Value = year.ToString();

                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }

            return ds;
        }
    }
}
