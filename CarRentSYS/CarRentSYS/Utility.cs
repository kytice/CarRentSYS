using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CarRentSYS
{
    class Utility
    {
        public static void LoadTypesData(ComboBox cboName)
        {
            DataSet ds = VehicleType.GetAllVehicleTypes();
            cboName.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboName.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
        }

        public static void LoadMakesData(ComboBox cboName)
        {
            DataSet ds = Model.GetAllMakes();
            cboName.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboName.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }

        public static void LoadModelsData(ComboBox cboName, string make)
        {
            DataSet modelsData = Model.GetAllModels(make);
            cboName.Items.Clear();

            foreach (DataRow row in modelsData.Tables["models"].Rows)
            {
                cboName.Items.Add(row["Model"].ToString());
            }
        }


        private static readonly Dictionary<char, string> transMap = new Dictionary<char, string>
    
        {
            {'M', "Manual"},
            {'A', "Automatic"}
        };

        private static readonly Dictionary<char, string> fuelMap = new Dictionary<char, string>
    
        {
            {'P', "Petrol"},
            {'D', "Diesel"},
            {'H', "Hybrid"},
            {'E', "Electric"}
        };

        public static string MapTransmission(char transValue)
        {
            if (transMap.ContainsKey(transValue))
            {
                return transMap[transValue];
            }
            else
            {
                return transValue.ToString();
            }
        }

        public static string MapFuel(char fuelValue)
        {
            if (fuelMap.ContainsKey(fuelValue))
            {
                return fuelMap[fuelValue];
            }
            else
            {
                return fuelValue.ToString();
            }
        }

        public static string FormatName(string txt)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt.ToLower());
        }
    }
}