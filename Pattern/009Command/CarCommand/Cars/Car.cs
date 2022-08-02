using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCommand.Cars
{
    public class Car
    {
        protected string arg;
        public Car(params string[] args) { arg = args.Length == 0 ? "NoName автомобиль" : args[0]; }
        public virtual void OpenCar() { Console.WriteLine($"{arg} открыт"); }
        public virtual void CloseCar() { Console.WriteLine($"{arg} закрыт"); }
        public virtual void StartEngine() { Console.WriteLine($"{arg} заведен"); }
        public virtual void StopEngine() { Console.WriteLine($"{arg} заглушен"); }
        public virtual void MoveStart() { Console.WriteLine($"Движениe начато"); }
        public virtual void MoveStop() { Console.WriteLine($"Движениe прекращено"); }
    }
}
