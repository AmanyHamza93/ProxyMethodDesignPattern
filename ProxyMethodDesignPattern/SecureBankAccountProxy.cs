

using System.Net.Sockets;

namespace ProxyMethodDesignPattern
{
    public class SecureBankAccountProxy : IBankAccount
    {
        private RealBankAccount realBankAccount;
        private string password;

        public SecureBankAccountProxy(string password)
        {
            this.password = password;
            Authenticate();
        }

        private void Authenticate()
        {
            if (password == "secret")
            {
                realBankAccount = new RealBankAccount();
                Console.WriteLine("Authentication successful");
            }
            else
            {
                Console.WriteLine("Authentication failed. Access denied.");
            }
        }
        public void Deposit(double amount)
        {
            if (realBankAccount != null)
            {
                realBankAccount.Deposit(amount);
            }
        }

        public void Withdraw(double amount)
        {
            if (realBankAccount != null)
            {
                realBankAccount.Withdraw(amount);
            }
        }

        public double GetBalance()
        {
            return (realBankAccount != null) ? realBankAccount.GetBalance() : 0.0;
        }
    }
}
