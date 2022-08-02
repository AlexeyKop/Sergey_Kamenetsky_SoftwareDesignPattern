using System;
using System.Collections.Generic;
using System.Text;

namespace PcComposite.Units
{
    public abstract class Unit
    {
        public string NameUnit { get; }
        protected string id;

        public Unit(string nameUnit) { this.NameUnit = nameUnit; }

        public abstract void Build(string args = "");
        public abstract void Set(Unit unit);
        public abstract void Delete(Unit unit);
        //public abstract Unit GetChild(int index);
    }
}
