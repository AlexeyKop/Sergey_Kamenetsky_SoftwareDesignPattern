namespace ContainerInstances
{
    class Client
    {
        public static void ButtonClick()
        {
            IView view = Container.Instance.Extract<IView>();
            ICalc calc = Container.Instance.Extract<ICalc>();
            _ = double.TryParse(view.X, out double a);
            _ = double.TryParse(view.Y, out double b);

            view.Result = $"{a} {calc.Operation} {b} = {calc.Result(a, b)}";
        }
    }
}
