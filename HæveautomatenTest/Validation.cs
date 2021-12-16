using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    public static class Validation
    {

        /// <summary>
        /// Checks if there are enough money on the account
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public static bool ValidateAmount(double amount, Card card)
        {
            if (amount < card.GetMoney())
            {
                return true;
            }
            return false;
        } 

        /// <summary>
        /// Checks if the inputed pincode is the same as the inserted card pincode
        /// </summary>
        /// <param name="userpin"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public static bool ValidatePin(int userpin, Card card)
        {
            if (userpin == card.PinCode)
            {
                return true;
            }
            return false;
        }
    }
}
