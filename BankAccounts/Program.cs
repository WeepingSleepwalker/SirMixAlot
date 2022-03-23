using System;
using System.Globalization;
using System.IO;

namespace BankAccounts
{
    class Program
    {

        static void Main()
        {

            SavingsAccount newAccount = new SavingsAccount("Personal Savings", 2468, 2500.75);

            Console.WriteLine("newAccount.Name= " + newAccount.accountName);
            Console.WriteLine("Current account number: " + newAccount.getAccountNumber());
            
            Console.WriteLine("Current account balance: " + newAccount.getAccountBalance());
            Console.WriteLine("Current account interestrate: " + newAccount.getInterestRate());

            newAccount.Withdrawl(1500);
 //testing the withdrawl methods           
            Console.WriteLine("Current account balance: " + newAccount.getAccountBalance());
            newAccount.Withdrawl(1500);
            Console.WriteLine("Current account balance: " + newAccount.getAccountBalance());
            newAccount.Withdrawl(-1000);
            Console.WriteLine("Current account balance: " + newAccount.getAccountBalance());
//testing the deposit method

            newAccount.Deposit(-1000);
            Console.WriteLine("Current account balance: " + newAccount.getAccountBalance());
            newAccount.Deposit(234);
            Console.WriteLine("Current account balance: " + newAccount.getAccountBalance());

//testing the applyInterest method

            newAccount.ApplyInterest();
            Console.WriteLine("Current account balance: " + newAccount.getAccountBalance());



            CheckingAccount newCheckingAccount = new CheckingAccount("Personal Checking", 22468, 250);

            Console.WriteLine("newChekcingAccount.Name= " + newCheckingAccount.accountName);
            Console.WriteLine("Current account number: " + newCheckingAccount.getAccountNumber());
            
            Console.WriteLine("Current account balance: " + newCheckingAccount.getAccountBalance());
            Console.WriteLine("Current account interestrate: " + newCheckingAccount.getInterestRate());

            newCheckingAccount.Deposit(-200);
            newCheckingAccount.Deposit(150);

            Console.WriteLine("Current account bal:" + newCheckingAccount.getAccountBalance());

            newCheckingAccount.Withdrawl(-100);
            newCheckingAccount.Withdrawl(1000000);
            newCheckingAccount.Withdrawl(150);
           Console.WriteLine("Current account bal:" + newCheckingAccount.getAccountBalance());

        }
    }
}
