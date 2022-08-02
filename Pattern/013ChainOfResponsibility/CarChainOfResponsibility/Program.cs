using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarChainOfResponsibility
{

    class Program
    {
        static void Main()
        {

            ArtificialIntelligencena jarvis = new ArtificialIntelligencena(LevelsOfResponsibility.AnsweringMachine); 
            Reseption reseption = new Reseption(LevelsOfResponsibility.Reception);
            Manager manager = new Manager(LevelsOfResponsibility.SalesManager);

            jarvis.Next = reseption;
            reseption.Next = manager;

            jarvis.Conversation("хочу машину", LevelsOfResponsibility.SalesManager);
            Console.WriteLine("\n\n");
            jarvis.Conversation("Время работы", LevelsOfResponsibility.Reception);
            Console.WriteLine("\n\n");
            jarvis.Conversation("Время работы", LevelsOfResponsibility.AnsweringMachine);

        }
    }
}
