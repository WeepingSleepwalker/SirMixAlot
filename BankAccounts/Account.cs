namespace BankAccounts
{
    abstract class Account
    {
        //Fields
        public string? accountName;
        protected int accountNumber;
        protected double accountBalance;
        protected double interestRate;


        //Constructor
        // public Account(string accountName, int accountNumber, double accountBalance, decimal interestRate)
        // {
        //     this.accountName = accountName;
        //     this.accountNumber = accountNumber;
        //     this.accountBalance = accountBalance;
        //     this.interestRate = interestRate;
        // }
        //Methods

         public int getAccountNumber()
         {
             return this.accountNumber;
         }

         public double getAccountBalance()
         {
             return this.accountBalance;
         }

         public double getInterestRate()
         {
             return this.interestRate;
         }

         public abstract void Withdrawl(double withdrawl );


         public abstract void Deposit(double deposit);

         protected void Record(double TranactionAmount)
         {  
             DateTime Current = DateTime.Now;

             string[] content = {(Current.ToString("F")) + this.accountNumber + "\t" + this.accountName + "\t" + TranactionAmount + "\t" + this.accountBalance};
             string path = @"./TransactionRecords.txt";

             if(!File.Exists(path))
             {
                 File.WriteAllLines(path, content);
                 File.Create(path).Close();
             }
             else
             {
                 //append the existing file
                 File.AppendAllLines(path, content);
                 File.Create(path).Close();
             }
         }
     
    }

}