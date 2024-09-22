using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentSYS
{
    public class ValidateVehicleTypeData
    {

        public string TypeCode { get; private set; }
        public string Name { get; private set; }
        public string DailyRate { get; private set; }

        public ValidateVehicleTypeData(string typeCode, string name, string dailyRate)
        {
            TypeCode = typeCode;
            Name = name;
            DailyRate = dailyRate;
        }

        public ValidateVehicleTypeData(string name, string dailyRate)
        {
            Name = name;
            DailyRate = dailyRate;
            TypeCode = null;
        }

        public string GetValidationMessage()
        {
            if (TypeCode != null)
            {
                if (string.IsNullOrEmpty(TypeCode))
                {
                    return "Type Code must be entered.";
                }
                if (TypeCode.Length != 3)
                {
                    return "Type Code must be exactly 3 letters.";
                }
                if (!TypeCode.All(char.IsLetter))
                {
                    return "Type Code must be alphabetic.";
                }

                string upTypeCode = TypeCode.ToUpper();

                if (VehicleType.TypeCodeExists(upTypeCode))
                {
                    return "Type Code already exists.";
                }
            }

            if (string.IsNullOrEmpty(Name))
            {
                return "Name must be entered.";
            }
            if (!decimal.TryParse(DailyRate, out decimal dailyRateValue))
            {
                return "Daily Rate must be a valid decimal number.";
            }
            if (dailyRateValue < 20m || dailyRateValue > 200m)
            {
                return "Daily Rate must be between €20 and €200.";
            }

            return string.Empty;
        }
    }
}
