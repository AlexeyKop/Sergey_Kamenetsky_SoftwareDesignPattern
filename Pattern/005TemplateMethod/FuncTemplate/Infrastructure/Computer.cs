using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncTemplate.Infrastructure
{
    static class Computer
    {
        public static void Run(
            Action turnOn,
            Func<bool> switchedOn,
            Action action,
            Action turnOff
            )
        {
            turnOn();
            while (switchedOn()) action();
            turnOff();
        }
    }
}
