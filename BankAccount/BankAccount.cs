using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)

        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; } 
        public double Balance { get; set; }

        //Lägg till Konstruktor

        public BankAccount(string accountnumber, string accountholder, double balance) 
        {
            AccountNumber = accountnumber;
            AccountHolder = accountholder;
            Balance = balance;
        }

        //Lägg till Metoder
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
            
        }

        public void Withdraw(double amount) 
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}, New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Not enough money in your account");
            }
            
            
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
        //Lycka till! :)
    }
}
