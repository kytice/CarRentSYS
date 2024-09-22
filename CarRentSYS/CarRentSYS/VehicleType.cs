using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Xml.Linq;

namespace CarRentSYS
{
    public class VehicleType
    {
        private string _typeCode;
        private string _name;
        private decimal _dailyRate;

        public string TypeCode
        {
            get { return _typeCode; }
            set { _typeCode = value.ToUpper(); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = Utility.FormatName(value); }
        }

        public decimal DailyRate
        {
            get { return _dailyRate; }
            set { _dailyRate = value; }
        }

        public VehicleType() { }

        public VehicleType(string typeCode, string name, decimal dailyRate)
        {
            TypeCode = typeCode;
            Name = name;
            DailyRate = dailyRate;
        }

        public static bool TypeCodeExists(string typeCode)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT COUNT(*) FROM Rates WHERE TypeCode = :TypeCode";

                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("TypeCode", OracleDbType.Varchar2).Value = typeCode;

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static DataSet GetAllVehicleTypes()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT typeCode, name, dailyRate FROM Rates ORDER BY typeCode";
                OracleDataAdapter da = new OracleDataAdapter(sqlQuery, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "types");
                return ds;
            }
        }

        public void AddVehicleType()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "INSERT INTO Rates (TypeCode, Name, DailyRate) VALUES (:TypeCode, :Name, :DailyRate)";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("TypeCode", OracleDbType.Varchar2).Value = TypeCode;
                    cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = Name;
                    cmd.Parameters.Add("DailyRate", OracleDbType.Decimal).Value = DailyRate;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateVehicleType()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "UPDATE Rates SET Name = :Name, DailyRate = :DailyRate WHERE TypeCode = :TypeCode";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = Name;
                    cmd.Parameters.Add("DailyRate", OracleDbType.Decimal).Value = DailyRate;
                    cmd.Parameters.Add("TypeCode", OracleDbType.Varchar2).Value = TypeCode;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static VehicleType GetVehicleTypeByCode(string typeCode)
        {
            VehicleType vehicleType = null;

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT TypeCode, Name, DailyRate FROM Rates WHERE TypeCode = :TypeCode";

                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add("TypeCode", OracleDbType.Varchar2).Value = typeCode;

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            vehicleType = new VehicleType
                            {
                                TypeCode = dr["TypeCode"].ToString(),
                                Name = dr["Name"].ToString(),
                                DailyRate = Convert.ToDecimal(dr["DailyRate"])
                            };
                        }
                    }
                }
            }
            return vehicleType;
        }
    }
}
