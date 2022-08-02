using static System.Console;
namespace BankCommand.Command
{
    class Account
    {
        public string AccountOwner { get; set; }
        public int Balance { get; set; }

        public Account(string accountOwner, int balance)
        {
            this.Balance = balance;
            this.AccountOwner = accountOwner;
        }

        public void Info() => WriteLine($"{AccountOwner}: ${Balance}");
    }
}
