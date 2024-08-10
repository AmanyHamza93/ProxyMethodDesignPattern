namespace ProxyMethodDesignPattern
{
    public interface IBankAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        double GetBalance();
    }
}
