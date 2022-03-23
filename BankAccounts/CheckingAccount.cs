namespace BankAccounts
{
    class CheckingAccount : Account
    {
        //Feilds

        //Constructor

        public CheckingAccount(string accountName, int accountNumber, double accountBalance)
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.interestRate = 0.00;
        }

        //Methods

        public override void Withdrawl(double withdrawl)
        {
            if(withdrawl<0)
           {
               Console.WriteLine("Withdrawls must be a positive value");
               Console.WriteLine("transaction canceled");
               return;
           } 
           else if((this.accountBalance - withdrawl) < 0)
           {
               Console.WriteLine("balance may not go below zero");
               Console.WriteLine("Transation canceled");
               return;
           }
           else
           {
               this.accountBalance -= withdrawl;
               this.Record(-withdrawl);
           }
        }

        public override void Deposit(double deposit)
        {
            if(deposit<0)
            {
               Console.WriteLine("Deposit must be a positive value");
               Console.WriteLine("transaction canceled");
               return;
            }
            else
           {
               this.accountBalance += deposit;
               this.Record(deposit);
           } 
        }
    }
}