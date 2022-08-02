namespace ContainerStatic
{
    class Program
    {
        static void Main()
        {
            Container container = Container.Instance;

            container.Register<ICalc, Div>();
            container.Register<IView, ConsoleView>();
            Foo.ButtonClick();

            container.Unregister<ICalc>();
            container.Register<ICalc, Sum>();

            Foo.ButtonClick();
        }
    }
}
