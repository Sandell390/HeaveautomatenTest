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

        /// <summary>
        /// withdraw money from account
        /// </summary>
        /// <param name="insertedCard">The inserted card || UserInput card</param>
        /// <param name="pincode">Userinput pincode</param>
        /// <param name="amount">The amount that should be withdrawed</param>
        /// <returns></returns>
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
