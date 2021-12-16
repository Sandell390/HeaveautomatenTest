using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    public class Account
    {
        public string AccountNumber { get; set; }

        public List<Card> Cards { get; set; }

        public double Balance { get; set; } = 1000;

        public Account()
        {
            Cards = new List<Card>();
            AccountNumber = GenAccountNumber();
        }

        public Card AddNewCard(int pinCode)
        {
            Card card = new Card(pinCode, this);
            Cards.Add(card);
            return card;
        }

        private string GenAccountNumber()
        {
            //Starts the accountnumber with 3520
            string accountNumber = "3520 ";

            Random random = new Random();

            //Generates 10 more number for accountnumber
            for (int i = 0; i < 10; i++)
            {
                accountNumber += random.Next(0, 9);
            }
            return "";
            
        }

    }
}
