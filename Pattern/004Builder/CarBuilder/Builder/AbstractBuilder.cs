using CarBuilder.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder.Builder
{
    public abstract class AbstractBuilder
    {
        public abstract void MakeSuspension();
        public abstract void MakeEngine();
        public abstract void MakeBody();

        public abstract Vehicle GetResult { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }
    }


}
