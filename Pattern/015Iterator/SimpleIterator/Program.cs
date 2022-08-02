using static System.Console;
using System.Linq;

namespace SimpleIterator
{

    class Program
    {
        static void Main()
        {
            var array = Enumerable.Range(1, 10).ToArray();

            //foreach (var item in array) Write($"{item} ");
            
            // Ошибка CS1579 Оператор foreach не работает с переменными типа "Set<int>"
            // так как "Set<int>" не содержит открытое
            // определение экземпляра или расширения для "GetEnumerator"
            //foreach (var item in set) Write($"{item} ");

            SimpleSet<int> set = new(array);

            WriteLine();

            set.Reset();
            while (set.MoveNext()) Write($"{set.Current} ");

            WriteLine();
            

        }
    }
}
