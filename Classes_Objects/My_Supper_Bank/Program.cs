namespace My_Supper_Bank;

class Program
{
    static void Main(string[] args)
    {
        // My Super Bank will support this requirements
        // 1. It has a 10-digit number that uniquely identifies the bank account.
        // 2. It has a string that stores the name or names of the owners.
        // 3. The balance can be retrieved.
        // 4. It accepts deposits.
        // 5. It accepts withdrawals.
        // 6. The initial balance must be positive.
        // 7. Withdrawals can't result in a negative balance.

        // Begin
        // Create a Bank_Account class and what a bank account should look like with different properties
        var account = new Bank_Account("Sang Thai", 10000);
        System.Console.WriteLine($"Account {account.Number} was created for {account.Onwer} with {account.Balance}.");

        account.MakeWithdrawal(120, DateTime.Now, "Hammock");
        System.Console.WriteLine($"New Balance: {account.Balance}");



    }
}
