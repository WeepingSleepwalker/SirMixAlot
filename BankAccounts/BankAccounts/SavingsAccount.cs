namespace BankAccounts
{
    public class SavingsAccount : Account
    {
        //Fields

        //Counstructor
        public SavingsAccount(string accountName, double accountBalance)
        {
            this.accountName = accountName;
            this.Deposit(accountBalance, "First Despost");
            this.interestRate = 0.03;
        }
        //Methods





        public void ApplyInterest()
        {
            this.Deposit(Math.Round(this.accountBalance * this.interestRate, 2), "Interest Payment");
        }
    }
}