using SimpleAdapter.Interfaces;
using static System.Console;

namespace SimpleAdapter.Moto
{
    /// Пример готового объекта
    /// адаптированного под цель
    class Honda : Motorcycle, ISport
    {
        public void MakeNoise() => WriteLine("hoooooooonnndaaaaaaa");
    }
}
