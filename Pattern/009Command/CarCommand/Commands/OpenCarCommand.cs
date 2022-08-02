using CarCommand.Cars;

namespace CarCommand.Commands
{
    public class OpenCarCommand : Command
    {
        public OpenCarCommand(Car car) : base(car) { }

        public override void Execute() { car.OpenCar(); } 
    }
}
