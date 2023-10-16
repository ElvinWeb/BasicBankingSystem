using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses.Models
{
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountHolder, double initialBalance, double interestRate , double accountId)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
            InterestRate = interestRate;
            AccountID = accountId;
        }

        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. Current balance: ${Balance}");

            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. Current balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Amount is great than Balance. This operation is declined!!");
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Savings Account - ID:{AccountID} Account Admin: {AccountHolder}, Balance: ${Balance}, Interest Rate: {InterestRate}%");
        }

    }
}
