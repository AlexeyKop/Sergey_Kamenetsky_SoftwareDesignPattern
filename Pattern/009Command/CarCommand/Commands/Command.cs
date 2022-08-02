using CarCommand.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCommand.Commands
{
    public abstract class Command
    {
        protected Car car;
        public Command(Car car)
        {
            this.car = car;
        }
        public abstract void Execute();
    }
}
