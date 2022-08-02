using CarCommand.Cars;
using CarCommand.Clients;
using CarCommand.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCommand
{
    class Program
    {
        static void Main()
        {
            Car cayenne = new Porsche("Cayenne");

            Driver driver = new ProfiDriver(
                 openCar: new OpenCarCommand(cayenne),
                 closeCar: new CloseCarCommand(cayenne),
                 startEngine: new StartEngineCommand(cayenne),
                 stopEngine: new StopEngineCommand(cayenne),
                 moveStart: new MoveStartCommand(cayenne),
                 moveStop: new MoveStopCommand(cayenne)
                );

            driver.OpenCar();
            driver.StartEngine();
            driver.Move();
            driver.Stop();
            driver.StopEngine();
            driver.CloseCar();


        }
    }
}
