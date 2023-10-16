using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses.Models
{
    public abstract class BankAccount
    {
        public string AccountHolder { get; set; }
        public double AccountID { get; set; }
        public double Balance { get; set; }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void DisplayAccountInfo();
    }
}
