using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SimplePrototype
{
    class Prototype : ICloneable
    {
        public Prototype() => Level = 1;
        
        public GameArmy HeroArmy { get; set; }
        public GameRace HeroRace { get; set; }
        public GameClass HeroClass { get; set; }
        public GameGender HeroGender { get; set; }

        public string Username { get; set; }
        public int Level { get; set; }

        public object Clone() => (this.MemberwiseClone() as Prototype);

        public override string ToString()
        {
            return String.Format(
                "{0} {1} {2} {3} {4}",
                HeroArmy,
                HeroRace,
                HeroClass,
                HeroGender,
                Username
                );
        }
    }
}