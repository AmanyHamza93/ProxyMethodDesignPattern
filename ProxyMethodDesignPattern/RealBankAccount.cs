namespace ProxyMethodDesignPattern
{
    public class RealBankAccount : IBankAccount
    {
        private double balance;
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($" Deposited: { amount}");
        }

        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: { amount}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
