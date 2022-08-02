using static System.Console;

namespace CompanyFlyweightIntro
{
    class Program
    {
        static void Main()
        {
            var db = Db.Instance;
            var j1 = db.GetOrCreateEmployee("Иван", "I");
            var j7 = db.GetOrCreateEmployee("Иван", "IV");
            

            WriteLine(j1);
            WriteLine(j7);
            
        }
    }
}