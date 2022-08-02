using BankCommand.Command;
using static System.Console;

namespace BankCommand
{
    class Program
    {
        static void Main()
        {

            // видео https://youtu.be/HXEtIt9hRrs

            Account account1 = new("user1", 0);
            Account account2 = new("user2", 0);
            Account account3 = new("user3", 0);

            account1.Info();
            account2.Info();
            account3.Info();

            var manager = OperationManager.Instanse;

            manager.AddOperation(new Deposit(account: account3, money: 1000));
            manager.AddOperation(new Deposit(account: account2, money: 2000));
            manager.AddOperation(new Deposit(account: account3, money: 3000));


            manager.ProcessOperations();
            account1.Info();
            account2.Info();
            account3.Info();

            manager.AddOperation(new Withdraw(account: account3, money: 500));
            manager.AddOperation(new Withdraw(account: account2, money: 500));
            manager.AddOperation(new Withdraw(account: account1, money: 500));

            manager.ProcessOperations();
            account1.Info();
            account2.Info();
            account3.Info();

            //NoCommandAccount account1 = new();

            //account1.Deposit(100);
            //account1.Withdraw(20);


            ReadLine();
        }
    }
}
