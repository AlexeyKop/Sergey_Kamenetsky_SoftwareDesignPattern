using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator.Cars.Decorator
{
    class MyCar
    {
        protected Car baseCar;
        public MyCar(string model, params string[] options)
            => baseCar = new Car(model, options);

        //public MyCar(Car car)
        //{
        //    baseCar = car; // в такой реализации не забываем про копирование
        //}

        public List<string> Options { get => baseCar.Options; }
        public int GetPrice() => baseCar.GetPrice() + 100;

        public void Move()
        {
            /// 
            baseCar.Move();
        }
        public void Stop()
        {
            baseCar.Stop();
            /// 
        }
        public override string ToString() => $"{baseCar} ++++";
    }
}
