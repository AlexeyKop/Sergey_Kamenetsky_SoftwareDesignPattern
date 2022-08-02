using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCommand.NoCommand
{
    class NoCommandAccount
    {
        private int balance;
        public int Balance => balance;
        public NoCommandAccount() => balance = 0;

        public void Deposit(int money)
        {
            if (money < 0) return;
            balance += money;
        }

        public void Withdraw(int money)
        {
            if (balance - money < 0) return;
            balance -= money;
        }
    }
}
