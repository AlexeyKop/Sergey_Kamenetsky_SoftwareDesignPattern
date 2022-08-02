using System;

namespace MonoState
{

    class Program
    {
        static void Main(string[] args)
        {
            // Модуль 1
            var setMainPage = new Settings
            {
                Columns = 2,
                Rows = 8
            };
            Console.WriteLine($"setMainPage Rows: {setMainPage.Rows} Columns: {setMainPage.Columns}\n");



            // Модуль 2
            var setSettingsPage = new Settings
            {
                Columns = 9,
                Rows = 9
            };
            Console.WriteLine($"setMainPage Rows: {setMainPage.Rows} Columns: {setMainPage.Columns}");
            Console.WriteLine($"setSettingsPage Rows: {setSettingsPage.Rows} Columns: {setSettingsPage.Columns}\n");



            // Модуль 3
            var setPvPPage = new Settings
            {
                Columns = 1,
                Rows = 5
            };

            Console.WriteLine($"setMainPage Rows: {setMainPage.Rows} Columns: {setMainPage.Columns}");
            Console.WriteLine($"setSettingsPage Rows: {setSettingsPage.Rows} Columns: {setSettingsPage.Columns}");
            Console.WriteLine($"setPvPPage Rows: {setPvPPage.Rows} Columns: {setPvPPage.Columns}");


        }
    }
}
