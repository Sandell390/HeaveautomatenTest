using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMProject;
using Xunit;

namespace TestLibrary.Tests
{
    public class Tests
    {
        static Account acc = new Account();

        ATM atm = new ATM();

        [Theory]
        [MemberData(nameof(WithdrawData))]
        public void Withdraw_ShouldWithdraw(double amount, Card card, int pincode, bool expected)
        {
            // Act
            bool actual = atm.Withdraw(card, pincode, amount);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(CardPinData))]
        public void Withdraw_ShouldVaildatePin(int userput, Card card, bool expected)
        {

            // Act
            bool actual = Validation.ValidatePin(userput, card);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(AccountAmountData))]
        public void Withdraw_ShouldVaildateAmount(double amount, Card card, bool expected)
        {
            // Arrange
            bool actual = Validation.ValidateAmount(amount, card);

            // Assert
            Assert.Equal(expected, actual);
        }



        public static List<object[]> CardPinData =>
        new List<object[]>
        {
            new object[] { 1234,
                acc.AddNewCard(1234),
                true },
            new object[] { 1564,
                acc.AddNewCard(1354),
                false },
            new object[] { 1234,
                acc.AddNewCard(1234),
                true },
        };

        public static List<object[]> AccountAmountData =>
        new List<object[]>
        {
            new object[] { 566.3,
                acc.AddNewCard(1234),
                true },
            new object[] { 1000.2,
                acc.AddNewCard(1354),
                false }
        };

        public static List<object[]> WithdrawData =>
        new List<object[]>
        {
            new object[] { 402, acc.AddNewCard(1234), 1234, true },
            new object[] { 1999, acc.AddNewCard(9800), 1234, false },
            new object[] { 275, acc.AddNewCard(3344), 7648, false },
        };
    }


}
