using BankCommand.Command.Interfaces;
using System.Linq;

namespace BankCommand.Command
{
    class OperationManager
    {
        static public OperationManager Instanse;
        static OperationManager() => Instanse = new OperationManager();
        private Operations transactions;
        private OperationManager() => transactions = new();

        public void AddOperation(IOperation operation) => transactions.Add(operation);

        public void ProcessOperations()
        {
            transactions.Where(op => !op.IsComplete)
                        .ToList()
                        .ForEach(op => op.Execute());
        }
    }
}
