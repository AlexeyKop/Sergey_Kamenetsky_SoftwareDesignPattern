using System;
using static System.Console;

namespace EmailComposite
{


    class Program
    {
        static void Main(string[] args)
        {
            // Видео https://youtu.be/h2AvQ-Epd1I

            EMail c = new EMail() { Name = "Христиан Иоганн Генрих Гейне" }; 
            c.Send();// Отправлено "Христиан Иоганн Генрих Гейне"
            EMail r = new EMail() { Name = "Рене Декарт" }; 
            r.Send(); // Отправлено "Рене Декарт"
            EMail u = new EMail() { Name = "Карл Теодор Вильгельм Вейерштрасс" }; 
            u.Send(); // Отправлено "Карл Теодор Вильгельм Вейерштрасс"
            EMail d = new EMail() { Name = "Джон фон Нейман" }; 
            d.Send(); // Отправлено "Джон фон Нейман"
            
            Group cr = new Group(c, r);
            cr.Send(); // Отправлено "Христиан Иоганн Генрих Гейне"
                       // Отправлено "Рене Декарт"
            WriteLine();
             
            Group crud = new Group(cr, u, d);
            crud.Send(); // Отправлено "Христиан Иоганн Генрих Гейне"
                         // Отправлено "Рене Декарт"
                         // Отправлено "Карл Теодор Вильгельм Вейерштрасс"
                         // Отправлено "Джон фон Нейман"

            WriteLine();
        }
    }
}
