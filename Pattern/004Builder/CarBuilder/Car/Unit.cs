using System.Collections.Generic;
using System.Text;

namespace CarBuilder.Car
{
    public abstract class Unit
    {
        public Unit() { this.ToMake(); }
        public abstract void ToMake();
    }
}
