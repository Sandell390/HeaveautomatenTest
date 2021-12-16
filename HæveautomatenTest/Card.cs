using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    public class Card
    {
        public Account Account { get; set; }

        public string CardNumber { get; set; }

        public int PinCode { get; }

        public Card(int pinCode, Account account)
        {
            PinCode = pinCode;
            Account = account;
            CardNumber = GenCardNumber(16, new string[] { "124","153","4553"});
        }

        private string GenCardNumber(int maxCardNumber, string[] prefix)
        {
            string cardNumbers = string.Empty;

            Random random = new Random();

            //Choose a random prefix
            string usedPrefix = prefix[random.Next(0, prefix.Length - 1)];

            //Gets the lenght of the remaining missing numbers
            maxCardNumber -= usedPrefix.Length;

            //Adds the prefix to string
            cardNumbers += usedPrefix;

            //Adds the remaining numbers to string
            for (int i = 0; i < maxCardNumber; i++)
            {
                cardNumbers += random.Next(0, 9).ToString();
            }

            //Make space between numbers
            int numberCount = 0;
            for (int i = 0; i < cardNumbers.Length; i++)
            {
                if (numberCount >= 4)
                {
                    cardNumbers = cardNumbers.Insert(i, " ");
                    numberCount = 0;
                }

                numberCount++;
            }

            return cardNumbers;
        }

        public double GetMoney()
        {
            return Account.Balance;
        }

    }
}
