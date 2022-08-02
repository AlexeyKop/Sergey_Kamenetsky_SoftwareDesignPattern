using CarCommand.Commands;

namespace CarCommand.Clients
{
    public class ProfiDriver : Driver
    {
        public ProfiDriver(
            OpenCarCommand openCar,
            CloseCarCommand closeCar,
            StartEngineCommand startEngine,
            StopEngineCommand stopEngine,
            MoveStartCommand moveStart,
            MoveStopCommand moveStop
            ) : base(openCar, closeCar, startEngine, stopEngine, moveStart, moveStop)
        {
        }
    }



}
