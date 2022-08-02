using static System.Console;

namespace MenuIterator
{

    class Program
    {
        static void Main()
        {
            Menu menu = new()
            {
                Coffee = new("Латте", 200),
                Soup = new("Том ям", 230),
                Pizza = new("Маргарита", 600),
            };

            foreach (var dish in menu) WriteLine(dish);
        }
    }
}
