using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    public class ATM
    {
        public ATM()
        {

        }

        public bool Withdraw(Card insertedCard, int pincode, double amount)
        {

            if (Validation.ValidatePin(pincode,insertedCard) && Validation.ValidateAmount(amount, insertedCard))
            {
                insertedCard.Account.Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
