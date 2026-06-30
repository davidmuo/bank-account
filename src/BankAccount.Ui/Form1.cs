using Banking;

namespace BankUi;

public partial class Form1 : Form
{
    private readonly BankAccount account = new();

    public Form1()
    {
        InitializeComponent();
        RefreshBalance();
    }

    private void DepositButton_Click(object? sender, EventArgs e)
    {
        TryRunTransaction(account.Deposit);
    }

    private void WithdrawButton_Click(object? sender, EventArgs e)
    {
        TryRunTransaction(account.Withdraw);
    }

    private void TryRunTransaction(Action<decimal> transaction)
    {
        statusLabel.Text = "";

        if (!decimal.TryParse(amountTextBox.Text, out var amount))
        {
            statusLabel.Text = "Enter a valid amount.";
            return;
        }

        try
        {
            transaction(amount);
            amountTextBox.Text = "";
            RefreshBalance();
        }
        catch (Exception ex)
        {
            statusLabel.Text = ex.Message;
        }
    }

    private void RefreshBalance()
    {
        balanceLabel.Text = $"Balance: {account.GetBalance():C}";
    }
}
