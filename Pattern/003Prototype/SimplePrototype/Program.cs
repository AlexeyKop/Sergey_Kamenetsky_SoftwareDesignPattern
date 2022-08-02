using System;
using System.Threading;

namespace SimplePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new Prototype();
            Console.WriteLine($"prototype: {prototype}");

            var hero = (Prototype)prototype.Clone();
            Console.WriteLine($"hero: {hero}");
            Console.WriteLine(new String('─', 50));

            hero.HeroClass = GameClass.Magician;
            hero.HeroRace = GameRace.Undead;
            hero.Username = "Герой 1";
            Console.WriteLine($"hero: {hero}");
            Console.WriteLine(new String('─', 50));

            var war = (Prototype)hero.Clone();
            war.HeroGender = GameGender.Male;
            war.HeroClass = GameClass.Warrior;
            war.HeroRace = GameRace.Troll;
            war.Username = "Защитник ";
            Console.WriteLine($"war: {war}");
            Console.WriteLine(new String('─', 50));

            Console.WriteLine($"hero: {hero}");
            Console.WriteLine($"war: {war}");
            //prototype: Horde Orc Hunter Male
            //hero: Horde Orc Hunter Male
            //──────────────────────────────────────────────────
            //hero: Horde Undead Magician Male Герой 1
            //──────────────────────────────────────────────────
            //war: Horde Troll Warrior Male Защитник
            //──────────────────────────────────────────────────
            //hero: Horde Undead Magician Male Герой 1
            //war: Horde Troll Warrior Male Защитник


        }
    }
}
