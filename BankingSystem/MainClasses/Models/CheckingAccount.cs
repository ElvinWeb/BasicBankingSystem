using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses.Models
{
    public class CheckingAccount : BankAccount
    {
        public double OverDraftLimit { get; set; }
        public CheckingAccount(string accountHolder, double initialBalance, double overdraftLimit , double accountId)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
            OverDraftLimit = overdraftLimit;
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
            if (amount <= Balance + OverDraftLimit && amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. Current balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Exceeded overdraft limit. Transaction declined.");
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Checking Account - ID:{AccountID} Account Admin: {AccountHolder}, Balance: ${Balance}, Overdraft Limit: ${OverDraftLimit}");
        }
    }
}
