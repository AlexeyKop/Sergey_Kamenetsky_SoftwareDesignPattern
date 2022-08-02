using static System.Console;

namespace BrokerChainOfResponsibility
{
    class Program
    {
        static void Main()
        {

            // Видео https://youtu.be/OxJY5pNwFaY

            var dota = new Game();
            var hero = new Hero("Queen Of Pain", attack: 80, armor: 4, dota);
            WriteLine(hero);  // Queen Of Pain: [80, 4]

            var dd = new DoubleDamageRune(hero, dota); WriteLine(hero); // Queen Of Pain: [160, 4]

            dd.Dispose(); WriteLine(hero); // Queen Of Pain: [80, 4]
            /// ===

            var halberd = new Halberd(hero, dota); WriteLine(hero); // Queen Of Pain: [0, 1000]

            halberd.Dispose(); WriteLine(hero); // Queen Of Pain:  [80, 4]

            /// ===
            dd = new DoubleDamageRune(hero, dota);
            halberd = new Halberd(hero, dota); WriteLine(hero); // Queen Of Pain:  [0, 1000]

            halberd.Dispose(); WriteLine(hero); // Queen Of Pain:  [160, 4]

            dd.Dispose(); WriteLine(hero); // Queen Of Pain:  [80, 4]

            /// ===
            dd = new DoubleDamageRune(hero, dota);
            var dd2 = new DoubleDamageRune(hero, dota); WriteLine(hero); // Queen Of Pain: [320, 4] 

            dd.Dispose(); WriteLine(hero); // Queen Of Pain: [160, 4]
            dd2.Dispose(); WriteLine(hero); // Queen Of Pain: [80, 4]

            // ===
            halberd = new Halberd(hero, dota); WriteLine(hero); // Queen Of Pain:  [0, 1000]
            dd = new DoubleDamageRune(hero, dota); WriteLine(hero);// Queen Of Pain:  [0, 1000]
            halberd.Dispose();
            WriteLine(hero); // Queen Of Pain: [160, 4]
            dd.Dispose();
        }
    }
}