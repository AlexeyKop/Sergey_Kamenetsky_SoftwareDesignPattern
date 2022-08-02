using CarCommand.Cars;

namespace CarCommand.Commands
{
    public class StopEngineCommand : Command
    {
        public StopEngineCommand(Car car) : base(car) { }

        public override void Execute() { car.StopEngine(); }
    }
}
