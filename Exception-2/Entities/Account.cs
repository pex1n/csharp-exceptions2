using System;
using Exception2.Entities.Exceptions;
namespace Exception2.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account()
        {
        }

        public Account(int number, string holder, double balance, double limit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = limit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");

            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;


        }
    }
}
