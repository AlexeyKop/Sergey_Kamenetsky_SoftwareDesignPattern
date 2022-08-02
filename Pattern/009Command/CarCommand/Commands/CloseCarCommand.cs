using CarCommand.Cars;

namespace CarCommand.Commands
{
    public class CloseCarCommand : Command
    {
        public CloseCarCommand(Car car) : base(car) { }

        public override void Execute() { car.CloseCar(); }
    }
}
