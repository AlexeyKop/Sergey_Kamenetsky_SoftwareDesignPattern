using PcComposite.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcComposite.Units
{
    public abstract class TopLevelComponent : Unit
    {
        protected List<Unit> units;
        public TopLevelComponent(string name) : base(name)
        {
            units = new List<Unit>();
            base.id = GenerationGuid.Get();
        }

        public override void Delete(Unit unit) { units.Remove(unit); }

        public override void Set(Unit unit) { units.Add(unit); }

        public void Add(params Unit[] unit) { units.AddRange(unit); }

        private void Act(string args)
        {
            Console.WriteLine($"{args}Узел: {this.NameUnit} Id {base.id}");
           
            foreach (var item in units)
            {
                //Console.WriteLine($"Инициализация узла: {item.NameUnit}.");
                item.Build(args + "  ");
            }
            
        }

        public override void Build(string args = "") { Act(args); }
    }

}
