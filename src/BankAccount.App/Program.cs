using Banking;

var account = new BankAccount();

while (true)
{
    Console.WriteLine();
    Console.WriteLine($"Balance: {account.GetBalance():C}");
    Console.WriteLine("1) Deposit  2) Withdraw  3) Exit");
    Console.Write("> ");

    try
    {
        switch (Console.ReadLine())
        {
            case "1":
                account.Deposit(ReadAmount());
                break;
            case "2":
                account.Withdraw(ReadAmount());
                break;
            case "3":
                return;
            default:
                Console.WriteLine("Unknown option.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

decimal ReadAmount()
{
    Console.Write("Amount: ");
    return decimal.TryParse(Console.ReadLine(), out var amount) ? amount : 0m;
}
