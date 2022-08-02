using System;

namespace PizzaDecorator
{
    class Program
    {
        static void Main()
        {

            //!!! в такой реализации не забываем про копирование

            

            //Pizza chickenPizza = new ChickenPizza(new Pizza());
            //// Dough ->  ChickenPizza ->
            //Console.WriteLine(chickenPizza.MakePizza());

            //var chickenCheesePizza = new Cheese(new ChickenPizza(new Pizza()));
            //// Dough ->  ChickenPizza -> Cheese ->
            //Console.WriteLine(chickenCheesePizza.MakePizza());

            //var chickenOlivesCheesePizza = new Olives(new Cheese(new ChickenPizza(new Pizza())));
            //// Dough ->  ChickenPizza -> Cheese -> Olives ->
            //Console.WriteLine(chickenOlivesCheesePizza.MakePizza());


            //Olives<ChickenPizza> chickenOlivesPizza = new Olives<ChickenPizza>();
            //WriteLine(chickenOlivesPizza.MakePizza());
            //Olives<Pepper<ChickenPizza>> allCompPizza = new Olives<Pepper<ChickenPizza>>();
            //WriteLine(allCompPizza.MakePizza());

        }
    }
}
