namespace Banking;

public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Deposit amount cannot be negative.", nameof(amount));

        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Withdrawal amount cannot be negative.", nameof(amount));

        if (amount > balance)
            throw new InvalidOperationException("Insufficient funds for this withdrawal.");

        balance -= amount;
    }

    public decimal GetBalance() => balance;
}
