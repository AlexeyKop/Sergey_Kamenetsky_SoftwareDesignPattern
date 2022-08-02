using FacadeSmartHouse.Devices;
using FacadeSmartHouse.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSmartHouse.Facade
{
    class Kitchen 
    {
        FacadeRoom facade;
        public Kitchen()
        {
            facade = new FacadeRoom();
        }
        
        public void TurnOn(BulbColor color = BulbColor.Cold, int channel = 0)
        {
            facade.DeviceActivate(color, 0);    
        }
    }
}