using CarCommand.Cars;

namespace CarCommand.Commands
{
    public class StartEngineCommand : Command
    {
        public StartEngineCommand(Car car) : base(car) { }

        public override void Execute() { car.StartEngine(); }
    }
}
