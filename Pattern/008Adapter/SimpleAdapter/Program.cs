using SimpleAdapter.Interfaces;
using SimpleAdapter.Moto;
using System.Collections.Generic;

namespace SimpleAdapter
{

    class Program
    {
        /// Клиент
        static void Main()
        {
            /// Тест
            /// 
            List<ISport> moto = new()
            {
                new Honda(),
                new TuningVoskhod(new Voskhod()) // Адаптировано
                // , new Voskhod() // ошибка. несоответсвие интерфейсов
            };

            foreach (var item in moto)
            {
                item.MakeNoise();
            }
        }
    }
}