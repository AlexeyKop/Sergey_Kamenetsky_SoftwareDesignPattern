using CarCommand.Cars;

namespace CarCommand.Commands
{
    public class MoveStartCommand : Command
    {
        public MoveStartCommand(Car car) : base(car) { }

        public override void Execute() { car.MoveStart(); }
    }
}
