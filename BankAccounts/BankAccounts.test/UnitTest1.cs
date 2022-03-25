using Xunit;
using System;
using BankAccounts;

namespace BankAccounts.test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange-any setup required to perform the test
        //act- where we invoke the behavior to test
        //assert - compare the result of the Act to an expected value

        Assert.Equal(true, true);
        // Assert.Equal((what we expect to get back ), (what we actually get back))

    }

    //typical naming convention
    //UnitofTest_TestCondition_CorrectBehavior
    [Fact]

    public void SavingsAccount_CreateSavingsAccount_ValidSavingsAccount()
    {
        //Arrange
        string gotcha = "testaccount";
        //Act
        var account = new SavingsAccount("testaccount", 1234.56);
        //ASsert

        Assert.Equal(account.accountName, gotcha);
    }

    [Fact]
    public void Transaction_CreateTransaction_ValideTransaction()
    {
        //Arrange
        DateTime redeye = DateTime.Now;
        //Act

        Transaction tran = new Transaction(1233.22,redeye, "TestDepot");
        //Assert

        Assert.Equal(tran.Date, redeye);
    }

    [Fact]

    public void Account_GetInterestRate_ReturnInterestRate()
    {
        //Arragne
        SavingsAccount saving = new SavingsAccount("Test", 10000);
        double expectedInterestRate = 0.03;
    
        //Act
        double actual = saving.getInterestRate();

        //Assert

        Assert.Equal(expectedInterestRate, actual);
    
    }

    [Fact]

    public void Account_InvalidWithdrawl_allTransactionsLengthUnchanged()
    {
        //Arrange
        SavingsAccount savings = new SavingsAccount("testAccout", 1000);
        int expectedAllTransactionsCount = 1;
        //Act
        savings.Withdrawl(1500);
        int actualAllTransactionsCount = savings.GetTransactionCount();

        //Asser

        Assert.Equal(expectedAllTransactionsCount, actualAllTransactionsCount);
    }

    [Fact]

    public void Account_validWithdrawl_allTransactionsLengthUnchanged()
    {
        //Arrange
        SavingsAccount savings = new SavingsAccount("testAccout", 1000);
        int expectedAllTransactionsCount = 2;
        //Act
        savings.Withdrawl(100);
        int actualAllTransactionsCount = savings.GetTransactionCount();

        //Asser

        Assert.Equal(expectedAllTransactionsCount, actualAllTransactionsCount);
    }
}