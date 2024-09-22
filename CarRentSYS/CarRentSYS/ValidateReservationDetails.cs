using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSYS
{
    internal class ValidateReservationDetails
    {
        public static bool IsReservationDetailsValid(string fName, string sName, string email, string phone)
        {
            if (string.IsNullOrWhiteSpace(fName) || ContainsNumber(fName) || fName.Length > 20)
            {
                MessageBox.Show("Please enter a valid first name (maximum length: 20 characters, no numeric characters allowed).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(sName) || ContainsNumber(sName) || sName.Length > 20)
            {
                MessageBox.Show("Please enter a valid last name (maximum length: 20 characters, no numeric characters allowed).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email) || email.Length > 100)
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(phone) || phone.Length > 12 || phone.Length < 10 || !IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Please enter a valid phone number. \n10-12 digits only. Only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                System.Net.Mail.MailAddress addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private static bool ContainsNumber(string input)
        {
            return input.Any(char.IsDigit);
        }

        private static bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 10 && phone.Length <= 12;
        }

    }
}
