using System;
using Exception2.Entities;
using Exception2.Entities.Exceptions;

namespace Exception2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine());
            Account account = new Account(number, holder, balance, limit);

            Console.WriteLine();
            Console.Write("Enter amout for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
                account.WithDraw(amount);
                Console.WriteLine($"New balance: {account.Balance}"); ;
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }


        }
    }
}
