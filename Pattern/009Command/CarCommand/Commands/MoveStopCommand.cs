using CarCommand.Cars;

namespace CarCommand.Commands
{
    public class MoveStopCommand : Command
    {
        public MoveStopCommand(Car car) : base(car) { }

        public override void Execute() { car.MoveStop(); }
    }
}
