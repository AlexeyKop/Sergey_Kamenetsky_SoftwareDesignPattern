namespace ContainerStatic
{
    class Foo
    {
        public static void ButtonClick()
        {
            IView view = Container.Instance.Extract<IView>();
            ICalc calc = Container.Instance.Extract<ICalc>();
            double.TryParse(view.X, out double a);
            double.TryParse(view.Y, out double b);
            view.Result = $"{a} {calc.Operation} {b} = {calc.Result(a, b)}";
        }
    }
}
