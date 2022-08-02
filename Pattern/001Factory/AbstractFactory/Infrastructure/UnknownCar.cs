using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Infrastructure
{
    class UnknownCar : AbstractCar
    {
        public override void Run()
        {
            Console.WriteLine("Наша компания не занимается реализацией этих автомобилей");
        }

        protected override AbstractCarBody CreateCarBody() { throw new NotImplementedException(); }
        protected override AbstractCarEngine CreateCarEngine() { throw new NotImplementedException(); }
        protected override AbstractCarSuspension CreateCarSuspension() { throw new NotImplementedException(); }
    }
}
