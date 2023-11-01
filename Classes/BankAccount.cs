using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projects_3.Classes
{
    internal class BankAccount
    {
        double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double Withdrawal(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return amount;
            }
            return 0;
        }

        public double DisplayBalance()
        {
            return balance;
        }
    }
}
