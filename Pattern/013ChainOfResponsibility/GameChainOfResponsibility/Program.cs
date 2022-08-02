using static System.Console;

namespace GameChainOfResponsibility
{

    public class Demo
    {
        static void Main()
        {
            var hero = new Hero("Queen Of Pain", attack: 80, armor: 4);
            WriteLine(hero); 
            // Queen Of Pain: [80, 4]

            var game = new Effect(hero);
            game.Add(new DoubleDamageRune(hero)); game.Handle(); 
            WriteLine(hero);
            // Queen Of Pain активировал руну двойного урона
            // Queen Of Pain: [160, 4]

            game.Add(new ArcaneRune(hero)); game.Handle(); WriteLine(hero);
            // Queen Of Pain активировал руну двойного урона
            // Queen Of Pain активировал руну волшебства
            // Queen Of Pain: [320, 4]

            game.Add(new Halberd(hero)); game.Handle(); WriteLine(hero);
            // Существо лишено сил, отчего оно не может атаковать.
            // Queen Of Pain:[0, 4]            
        }
    }
}