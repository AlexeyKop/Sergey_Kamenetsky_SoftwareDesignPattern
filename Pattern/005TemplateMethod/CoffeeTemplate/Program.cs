using SimpleTemplate.Beverages;
using static System.Console;

namespace SimpleTemplate
{

    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            coffee.MakeElixir();

            

            Tea tea = new Tea();
            tea.MakeElixir();

        }
    }
}
