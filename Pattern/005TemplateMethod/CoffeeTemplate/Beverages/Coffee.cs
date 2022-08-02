using static System.Console;

namespace SimpleTemplate.Beverages
{

    //after
    class Coffee : Elixir
    {
        protected override void AddСomponent() => WriteLine("Добавить кофе");
        private void AddLemon() => WriteLine("Кофе с лимоном - напиток Богов!");

        protected override void Something() => AddLemon();
    }

    // before
    //class Coffee
    //{
    //    private void BoilWater() => WriteLine("Вскипятить воду");
    //    private void AddCoffee() => WriteLine("Добавить кофе");
    //    private void AddSugar() => WriteLine("Сахар по вкусу");
    //    private void AddLemon() => WriteLine("Кофе с лимоном - напиток Богов!");

    //    public void MakeCoffee()
    //    {
    //        BoilWater();
    //        AddCoffee();
    //        AddSugar();
    //        AddLemon();
    //        WriteLine();
    //    }
    //}
}
