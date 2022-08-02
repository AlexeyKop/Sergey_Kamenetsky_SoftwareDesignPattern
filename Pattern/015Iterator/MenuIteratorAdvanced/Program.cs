using static System.Console;

namespace MenuIteratorAdvanced
{

    class Program
    {
        static void Main()
        {
            Menu menu = new()
            {
                Coffee = new Dish("Латте", 200, proteins: 111, fats: 222, carbohydrates: 333),
                Soup = new("Том ям", 230, proteins: 333, fats: 444, carbohydrates: 111),
                Pizza = new("Маргарита", 600, proteins: 111, fats: 444, carbohydrates: 777),
            };

            foreach (var dish in menu)
            {
                Write($"{dish} - Max: {dish.AverageNutrients} [ ");
                foreach (var st in dish)
                {
                    Write($"{st} ");
                }
                WriteLine("] ");
            }

            //Name: Латте Weight: 200 - Max: 222[111 222 333]
            //Name: Маргарита Weight: 600 - Max: 444[111 444 777]
            //Name: Том ям  Weight: 230 - Max: 296[333 444 111]

        }
    }
}
