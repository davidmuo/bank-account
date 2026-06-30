using NUnit.Framework;
using Banking;

namespace Banking.Tests;

public class BankAccountTests
{
    [Test]
    public void NewAccount_HasZeroBalance()
    {
        var account = new BankAccount();

        Assert.That(account.GetBalance(), Is.EqualTo(0m));
    }

    [Test]
    public void Deposit_IncreasesBalance()
    {
        var account = new BankAccount();

        account.Deposit(100m);

        Assert.That(account.GetBalance(), Is.EqualTo(100m));
    }

    [Test]
    public void Deposit_Negative_ThrowsArgumentException()
    {
        var account = new BankAccount();

        Assert.Throws<ArgumentException>(() => account.Deposit(-1m));
    }

    [Test]
    public void Withdraw_DecreasesBalance()
    {
        var account = new BankAccount();
        account.Deposit(100m);

        account.Withdraw(40m);

        Assert.That(account.GetBalance(), Is.EqualTo(60m));
    }

    [Test]
    public void Withdraw_Negative_ThrowsArgumentException()
    {
        var account = new BankAccount();

        Assert.Throws<ArgumentException>(() => account.Withdraw(-1m));
    }

    [Test]
    public void Withdraw_MoreThanBalance_ThrowsInvalidOperationException()
    {
        var account = new BankAccount();
        account.Deposit(50m);

        Assert.Throws<InvalidOperationException>(() => account.Withdraw(50.01m));
    }
}
