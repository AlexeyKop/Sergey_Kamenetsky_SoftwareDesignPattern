using BankCommand.Command.Interfaces;

namespace BankCommand.Command
{
    class Deposit : IOperation
    {
        private readonly Account account;
        private readonly int money;
        private bool isComplete;
        public bool IsComplete { get => isComplete; }

        public Deposit(Account account, int money)
        {
            this.account = account;
            this.money = money;
            isComplete = false;
        }

        public void Execute()
        {
            account.Balance += money;
            isComplete = true;
        }
    }
}
