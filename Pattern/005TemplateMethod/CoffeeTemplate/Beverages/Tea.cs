using static System.Console;

namespace SimpleTemplate.Beverages
{

    // after
    class Tea : Elixir
    {
        protected override void AddСomponent() => WriteLine("Добавить чай");
        private void AddMilk() => WriteLine("Час с молоком - это прекрасно!");

        protected override void Something() => AddMilk();
    }

    // before
    //class Tea
    //{
    //    private void BoilWater() => WriteLine("Вскипятить воду");
    //    private void AddTea() => WriteLine("Добавить чай");
    //    private void AddSugar() => WriteLine("Сахар по вкусу");
    //    private void AddMilk() => WriteLine("Час с молоком - это прекрасно!");

    //    public void MakeTea()
    //    {
    //        BoilWater();
    //        AddTea();
    //        AddSugar();
    //        AddMilk();
    //        WriteLine();
    //    }
    //}
}
