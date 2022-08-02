namespace SimpleToAbstractFactory
{
    class UnknownCar : ICar
    {
        public void Drive()
        {
            System.Console.WriteLine("Упс... Что-то пошло не так");
        }
    }
}
