using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    public static class Validation
    {
        public static bool ValidateAmount(double amount, Card card)
        {
            if (amount < card.GetMoney())
            {
                return true;
            }
            return false;
        } 

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
