using BankCommand.Command.Interfaces;

namespace BankCommand.Command
{
    class Withdraw : IOperation
    {
        private readonly Account account;
        private readonly int money;
        private bool isComplete;
        public bool IsComplete { get => isComplete; }

        public Withdraw(Account account, int money)
        {
            this.account = account;
            this.money = money;
            isComplete = false;
        }

        public void Execute()
        {
            if (account.Balance - money < 0) return;
            account.Balance -= money;
            isComplete = true;
        }
    }
}
