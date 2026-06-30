namespace BankUi;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private Label balanceLabel;
    private TextBox amountTextBox;
    private Button depositButton;
    private Button withdrawButton;
    private Label statusLabel;

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        balanceLabel = new Label();
        amountTextBox = new TextBox();
        depositButton = new Button();
        withdrawButton = new Button();
        statusLabel = new Label();

        SuspendLayout();

        balanceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        balanceLabel.Location = new Point(20, 20);
        balanceLabel.Size = new Size(340, 40);
        balanceLabel.Text = "Balance: $0.00";

        amountTextBox.Location = new Point(20, 80);
        amountTextBox.Size = new Size(340, 27);
        amountTextBox.PlaceholderText = "Amount";

        depositButton.Location = new Point(20, 120);
        depositButton.Size = new Size(160, 35);
        depositButton.Text = "Deposit";
        depositButton.Click += DepositButton_Click;

        withdrawButton.Location = new Point(200, 120);
        withdrawButton.Size = new Size(160, 35);
        withdrawButton.Text = "Withdraw";
        withdrawButton.Click += WithdrawButton_Click;

        statusLabel.ForeColor = Color.Red;
        statusLabel.Location = new Point(20, 170);
        statusLabel.Size = new Size(340, 60);

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380, 250);
        Controls.Add(balanceLabel);
        Controls.Add(amountTextBox);
        Controls.Add(depositButton);
        Controls.Add(withdrawButton);
        Controls.Add(statusLabel);
        Text = "Bank Account";

        ResumeLayout(false);
        PerformLayout();
    }
}
