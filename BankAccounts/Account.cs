using System.Xml.Serialization;

namespace BankAccounts
{
     class Account
    {

        //Fields
        private static int accountSeed= 111111;
        public string? accountName;
        protected int accountNumber;
        protected double accountBalance
        {
            get
            {
                double balance = 0;
                foreach(var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        protected double interestRate;

        private List<Transaction> allTransactions = new List<Transaction>();

        public XmlSerializer Serializer {get;} = new( typeof(List<Transaction>));

        protected Account()
        {
            this.accountNumber = accountSeed;
            accountSeed++;
        }
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

         public void Withdrawl(double amount, string note = "" )
         {
         if(amount<0)
           {
               Console.WriteLine("Withdrawls must be a positive value");
               Console.WriteLine("transaction canceled");
               return;
           } 
           else if((this.accountBalance - amount) < 0)
           {
               Console.WriteLine("balance may not go below zero");
               Console.WriteLine("Transation canceled");
               return;
           }
           else
           {
            //    this.accountBalance -= withdrawl;
            //    this.Record(-withdrawl);
            var withdrawl = new Transaction(-amount, DateTime.Now, note);
            allTransactions.Add(withdrawl);

           }
         }


         public void Deposit(double amount, string note = ""){
            if(amount<0)
            {
               Console.WriteLine("Deposit must be a positive value");
               Console.WriteLine("transaction canceled");
               return;
            }
            else
           {
            //    this.accountBalance += deposit;
            //    this.Record(deposit);
            var deposit = new Transaction(amount, DateTime.Now, note);
            allTransactions.Add(deposit);
           } 
        }
         

         protected void Record(double TransactionAmount)
         {  
             DateTime Current = DateTime.Now;

             string[] content = {(Current.ToString("F")) + this.accountNumber + "\t" + this.accountName + "\t" + TransactionAmount + "\t" + this.accountBalance};
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

         public void SerializeAsXml()
         {
             var newStringWriter = new StringWriter();
             Serializer.Serialize(newStringWriter, allTransactions);
             newStringWriter.Close();

             string path = $"./Transactions-{this.accountNumber}.xml";
             File.WriteAllText(path, newStringWriter.ToString());
         }
     
    }

}