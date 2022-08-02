using static System.Console;

namespace SimpleAdapter.Moto
{
    /// Что адаптируем
    class Voskhod : Motorcycle
    {
        public void Sound() => WriteLine("drdrdr");
    }
}
