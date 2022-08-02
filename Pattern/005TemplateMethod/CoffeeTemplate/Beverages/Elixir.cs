using static System.Console;

namespace SimpleTemplate.Beverages
{

    //adter
    public abstract class Elixir
    {
        protected virtual void BoilWater() => WriteLine("Вскипятить воду");
        protected abstract void AddСomponent();
        protected virtual void AddSugar() => WriteLine("Сахар по вкусу");
        protected abstract void Something();
        public virtual void MakeElixir()
        {
            BoilWater();
            AddСomponent();
            AddSugar();
            Something();
            WriteLine();
        }
    }


    // before
    //class Elixir
    //{
    //}
}
