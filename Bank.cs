using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMarks
{
    class Bank
    {
        enum TransactionType
        {
            Deposit, Withdraw

        }
        internal class Account
        {
            private long accountNo;
            private string customerName;
            private string accountType;
            private TransactionType transaction;
            private double amount;
            private double balance;

            public Account() { /*Default Constructor*/ }

            public long AccountNo { get => accountNo; set => accountNo = value; }
            public string CustomerName { get => customerName; set => customerName = value; }
            public double Amount { get => amount; set => amount = value; }
            public double Balance { get => balance; set => balance = value; }
            public string AccountType { get => accountType; set => accountType = value; }
            internal TransactionType Transaction { get => transaction; set => transaction = value; }

            public double Deposit(Account b1)
            {
                return balance + b1.Amount;
            }
            public double Withdraw(Account b1)
            {
                return balance - b1.Amount;
            }
            public void Display()
            {
                Console.WriteLine("\nAccount Name : " + CustomerName + "\nAccount Number : " + AccountNo + "\nAccount Type : " + AccountType + "\nBalance : " + Balance);
            }
        }
    }
}