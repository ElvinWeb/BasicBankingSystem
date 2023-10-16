using MainClasses.Models;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount savingsAccount = new SavingsAccount("Elvin Sarkarov", 500, 3, 1);
            savingsAccount.DisplayAccountInfo();
            savingsAccount.Deposit(500);
            savingsAccount.Withdraw(1200);

            Console.WriteLine("<====================>");

            BankAccount checkingAccount = new CheckingAccount("Ismail Qafarov", 1500, 500,1);
            checkingAccount.DisplayAccountInfo();
            checkingAccount.Deposit(200);
            checkingAccount.Withdraw(1800);

        }
    }
}