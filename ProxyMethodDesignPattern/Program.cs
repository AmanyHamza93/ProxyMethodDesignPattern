using ProxyMethodDesignPattern;

IBankAccount account = new SecureBankAccountProxy("secret");

// Operations
account.Deposit(1000);
account.Withdraw(500);
double balance = account.GetBalance();

Console.WriteLine($"Current Balance: { balance}");