using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSYS
{
    internal class ValidateVehicleData
    {
        public static string IsValidRegNum(string regNum)
        {
            if (regNum.Length < 8 || regNum.Length > 9)
                return "Registration number length must be between 8 and 9 characters.";

            string yearSubstring = regNum.Substring(0, 2);
            string halfSubstring = regNum.Substring(2, 1);
            string countySubstring = regNum.Substring(3);

            for (int i = countySubstring.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(countySubstring[i]))
                    countySubstring = countySubstring.Remove(i);
                else
                    break; 
            }

            if (!int.TryParse(yearSubstring, out int year) || year < 21 || year > 24)
                return "Year must be between 21 and 24.";

            if (halfSubstring != "1" && halfSubstring != "2")
                return "Third character must be '1' or '2'.";

            if (countySubstring.Length < 1 || countySubstring.Length > 2 || !countySubstring.All(char.IsLetter))
                return "County code must contain 1 or 2 letters.";

            if (Vehicle.RegNumExists(regNum))
            {
                return "Vehicle with this registration number already exists.";
            }
            return null;
        }
    }
}

