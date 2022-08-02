using PcComposite.Exceptions;
using PcComposite.Helper;
using System;

namespace PcComposite.Units
{
    public abstract class LowLevelComponent : Unit
    {
        public LowLevelComponent(string name) : base(name)
        {
            base.id = GenerationGuid.Get();
        }

        public override void Delete(Unit unit) { throw new NotTopLevelComponentException(); }

        public override void Set(Unit unit) { throw new NotTopLevelComponentException(); }

        public override void Build(string args) { Console.WriteLine($"{args}Деталь {base.NameUnit}. Id {base.id}"); }
    }

}
