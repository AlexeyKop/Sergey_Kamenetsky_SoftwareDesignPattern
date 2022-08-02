namespace BankCommand.Command.Interfaces
{
    interface IOperation
    {
        void Execute();
        public bool IsComplete { get; }
    }
}
