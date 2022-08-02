using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator.Cars
{
    public sealed class Car
    {
        public string Model { get; set; }
        public Car(string model, params string[] options) { }
        public List<string> Options { get; set; }
        public int GetPrice() { return 0; }
        public void Move() { }
        public void Stop() { }
        public override string ToString() { return String.Empty; }
    }
}
