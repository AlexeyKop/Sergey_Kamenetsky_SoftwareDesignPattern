using System;
using System.Collections.Generic;

namespace CarBuilder.Car
{
    public abstract class Vehicle
    {
        List<Unit> parts;
        public Vehicle()
        {
            parts = new List<Unit>();
        }
        public void AddPart(Unit unit)
        {
            parts.Add(unit);
        }

        public override string ToString()
        {
            return $"Транспортное средство <{this.GetType().Name}>\n";
        }
    }
}
