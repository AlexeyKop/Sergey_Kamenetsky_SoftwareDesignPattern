namespace PizzaDecorator.Caffe.Decorator
{
    class Olives : Pizza
    {
        readonly Pizza pizza;
        public Olives(Pizza pizza)
        {
            this.pizza = pizza; // в такой реализации не забываем про копирование (прототип)
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + " Olives ->";
        }
    }



}
