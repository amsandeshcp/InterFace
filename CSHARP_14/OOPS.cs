using System;
using System.Collections.Generic;

namespace CSHARP_14
{
    class OOPS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****WORKING WITH CLASSES AND OBJECTS******");
            Console.WriteLine("\n");



            BankAccount account = new BankAccount("Lavi", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with{account.Balance}");

            Console.WriteLine("\n");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            Console.WriteLine("\n");

            Console.WriteLine(account.GetAccountHistory());

            //Test For Negative Balance
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
        }
    }
}
