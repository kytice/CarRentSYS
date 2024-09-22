using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CarRentSYS
{
    public class Vehicle
    {
        private string _regNum;
        private int _modelID;
        private string _typeCode;
        private char _trans;
        private char _fuel;
        private char _avail = 'A';

        public string RegNum
        {
            get { return _regNum; }
            set { _regNum = value.ToUpper(); }
        }

        public int ModelID
        {
            get { return _modelID; }
            set { _modelID = value; }
        }

        public string TypeCode
        {
            get { return _typeCode; }
            set { _typeCode = value.ToUpper(); }
        }

        public char Trans
        {
            get { return _trans; }
            set { _trans = value; }
        }

        public char Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public char Avail
        {
            get { return _avail; }
            set { _avail = value; }
        }

        public Vehicle() { }

        public Vehicle(string regNum, int modelID, string typeCode, char trans, char fuel, char avail = 'A')
        {
            RegNum = regNum;
            ModelID = modelID;
            TypeCode = typeCode;
            Trans = trans;
            Fuel = fuel;
            Avail = avail;
        }

        public static bool RegNumExists(string regNum)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT 1 FROM Vehicles WHERE RegNum = :RegNum";

                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":RegNum", OracleDbType.Varchar2).Value = regNum;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }

        public static bool HasReservedOrPickedUpReservations(string regNum)
        {
            string sqlQuery = "SELECT COUNT(*) FROM Reservations WHERE RegNum = :regNum AND (Status = 'R' OR Status = 'P')";

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":regNum", OracleDbType.Varchar2).Value = regNum;

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public static DataTable GetAllAvailableVehicles()
        {
            DataTable dt = new DataTable();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
                {
                    conn.Open();

                    string sqlQuery = "SELECT v.RegNum, m.Make, m.Model, v.TypeCode, v.Trans, v.Fuel " +
                                    "FROM Vehicles v " +
                                    "INNER JOIN Models m ON v.ModelID = m.ModelID " +
                                    "WHERE v.avail = 'A' " +
                                    "ORDER BY v.RegNum";

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


        public static DataTable GetVehicleDetails(string searchRegNum)
        {
            DataTable dt = new DataTable();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
                {
                    conn.Open();

                    string sqlQuery = "SELECT v.RegNum, v.TypeCode, v.Trans, v.Fuel, v.avail, m.Make, m.Model " +
                                      "FROM Vehicles v " +
                                      "INNER JOIN Models m ON v.ModelID = m.ModelID " +
                                      "WHERE v.RegNum = :searchRegNum AND v.avail != 'D'";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(":searchRegNum", OracleDbType.Varchar2).Value = searchRegNum;
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


        public void AddVehicle()
        {
            string sqlQuery = "INSERT INTO Vehicles (regNum, modelID, typeCode, trans, fuel, avail) VALUES (:regNum, :modelID, :typeCode, :trans, :fuel, 'A')";

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":regNum", OracleDbType.Varchar2).Value = RegNum;
                    cmd.Parameters.Add(":modelID", OracleDbType.Int32).Value = ModelID;
                    cmd.Parameters.Add(":typeCode", OracleDbType.Varchar2).Value = TypeCode;
                    cmd.Parameters.Add(":trans", OracleDbType.Char).Value = Trans;
                    cmd.Parameters.Add(":fuel", OracleDbType.Char).Value = Fuel;

                    cmd.ExecuteNonQuery();
                }
            }
        }
                                                                                                 

        public void UpdateVehicle()
        {
            string sqlQuery = "UPDATE Vehicles SET modelID = :modelID, typeCode = :typeCode, trans = :trans, fuel = :fuel " + 
                              "WHERE regNum = :regNum";

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {

                    cmd.Parameters.Add(":modelID", OracleDbType.Int32).Value = ModelID;
                    cmd.Parameters.Add(":typeCode", OracleDbType.Varchar2).Value = TypeCode;
                    cmd.Parameters.Add(":trans", OracleDbType.Char).Value = Trans;
                    cmd.Parameters.Add(":fuel", OracleDbType.Char).Value = Fuel;
                    cmd.Parameters.Add(":regNum", OracleDbType.Varchar2).Value = RegNum;

                    cmd.ExecuteNonQuery();
                    
                }
            }
        }

        public void DiscontinueVehicle(string regNum)
        {
            
            string sqlQuery = "UPDATE Vehicles SET avail = 'D' WHERE regNum = :regNum";

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":regNum", OracleDbType.Varchar2).Value = regNum;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetAvailableVehiclesForType(string typeCode, string pickupDate, string returnDate)
        {
            string sqlQuery = "SELECT DISTINCT v.RegNum, m.Make, m.Model, v.Trans, v.Fuel " +
                              "FROM Vehicles v " +
                              "INNER JOIN Models m ON v.ModelID = m.ModelID " +
                              "INNER JOIN Rates t ON v.TypeCode = t.TypeCode " +
                              "LEFT JOIN Reservations r ON v.RegNum = r.RegNum " +
                              "WHERE v.Avail = 'A' " +
                              "AND ((r.PickupDate IS NULL OR TO_DATE(:returnDate, 'DD-MON-YY') <= r.PickupDate) " +
                              "OR (r.ReturnDate IS NULL OR TO_DATE(:pickupDate, 'DD-MON-YY') >= r.ReturnDate)) " +
                              "AND t.TypeCode = :typeCode " +
                              "AND NOT EXISTS (SELECT 1 FROM Reservations rs WHERE v.RegNum = rs.RegNum " +
                              "AND rs.PickupDate <= TO_DATE(:pickupDate, 'DD-MON-YY') " +
                              "AND rs.ReturnDate >= TO_DATE(:returnDate, 'DD-MON-YY'))";

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":pickupDate", OracleDbType.Varchar2).Value = pickupDate;
                    cmd.Parameters.Add(":returnDate", OracleDbType.Varchar2).Value = returnDate;
                    cmd.Parameters.Add(":typeCode", OracleDbType.Varchar2).Value = typeCode;

                    DataTable dataTable = new DataTable();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }
    }
}
