namespace BankAccounts
{
    class CheckingAccount : Account
    {
        //Feilds

        //Constructor

        public CheckingAccount(string accountName, double accountBalance)
        {
            this.accountName = accountName;
            this.Deposit(accountBalance, "First Deposit");
            this.interestRate = 0.00;
        }

        //Methods




    }
}