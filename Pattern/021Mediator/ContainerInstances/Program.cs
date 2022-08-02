namespace ContainerInstances
{
    class Program
    {
        static void Main()
        {
            Container c = Container.Instance;
            c.Register<ICalc>(new Mult() { });
            c.Register<IView>(new ConsoleView());

            Client.ButtonClick();

            c.Unregister<ICalc>();

            c.Register<ICalc>(new Div());
            Client.ButtonClick();
        }
    }
}
