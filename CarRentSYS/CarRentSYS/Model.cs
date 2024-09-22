using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentSYS
{
    public class Model
    {

        private string _make;
        private string _model;

        public static int GetModelID(string make, string model)
        {
            int modelID = -1;
            string sqlQuery = "SELECT modelID FROM Models WHERE make = :make AND model = :model";

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":make", OracleDbType.Varchar2).Value = make;
                    cmd.Parameters.Add(":model", OracleDbType.Varchar2).Value = model;

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        modelID = Convert.ToInt32(result);
                    }
                }
            }
            return modelID;
        }

        public static DataSet GetAllMakes()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT DISTINCT Make FROM Models";

                conn.Open();

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "makes");
                    return ds;
                }
            }
        }

        public static DataSet GetAllModels(string make)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlQuery = "SELECT DISTINCT Model FROM Models WHERE Make = :make";

                conn.Open();

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":make", OracleDbType.Varchar2).Value = make;

                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "models");
                        return ds;
                    }
                }
            }
        }


    }
}
