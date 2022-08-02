using CarCommand.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCommand.Clients
{
    public abstract class Driver
    {
        #region comands

        OpenCarCommand openCarCommand;
        CloseCarCommand closeCarCommand;
        StartEngineCommand startEngineCommand;
        StopEngineCommand stopEngineCommand;
        MoveStartCommand moveStartCommand;
        MoveStopCommand moveStopCommand;

        #endregion

        public Driver(
        #region args

            OpenCarCommand openCar,
            CloseCarCommand closeCar,
            StartEngineCommand startEngine,
            StopEngineCommand stopEngine,
            MoveStartCommand moveStart,
            MoveStopCommand moveStop

        #endregion
            )
        {
            this.openCarCommand = openCar;
            this.closeCarCommand = closeCar;
            this.startEngineCommand = startEngine;
            this.stopEngineCommand = stopEngine;
            this.moveStartCommand = moveStart;
            this.moveStopCommand = moveStop;
        }

        public virtual void OpenCar() { this.openCarCommand.Execute(); }
        public virtual void CloseCar() { this.closeCarCommand.Execute(); }
        public virtual void StartEngine() { this.startEngineCommand.Execute(); }
        public virtual void StopEngine() { this.stopEngineCommand.Execute(); }
        public virtual void Move() { this.moveStartCommand.Execute(); }
        public virtual void Stop() { this.moveStopCommand.Execute(); }

    }



}
