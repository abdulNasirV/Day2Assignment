using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMarks
{
    class AccountMain
    {
        public static void Main()
        {
            Account b1 = new Account();
            Console.WriteLine("Enter You Bank Details :");
            Console.Write("\nCustomer Name : ");
            b1.CustomerName = Console.ReadLine();
            Console.Write("\nAccount Number : ");
            b1.AccountNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nAccount Type (SAVINGS or SALARY) : ");
            b1.AccountType = Console.ReadLine();
            Console.Write("\nBalance : ");
            b1.Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose Transaction Type \n1. Deposit\n2. Withdraw");
            int choice = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            while (flag == 0)
            {
                Console.Write("\nEnter The Amount : ");
                b1.Amount = Convert.ToDouble(Console.ReadLine());
                if (b1.Balance >= b1.Amount && choice == 2)
                {
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("Invalid Amount ");
                    continue;
                }
            }
            switch (choice - 1)
            {
                case (int)TransactionType.Deposit:

                    b1.Balance = b1.Deposit(b1);
                    break;
                case (int)TransactionType.Withdraw:

                    b1.Balance = b1.Withdraw(b1);
                    break;
                default:
                    Console.WriteLine("Enter A Valid option");
                    break;
            }
            b1.Display();
            Console.ReadKey();
        }
    }
}

