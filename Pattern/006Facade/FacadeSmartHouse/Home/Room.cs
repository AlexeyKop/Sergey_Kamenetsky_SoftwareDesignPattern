using FacadeSmartHouse.Devices;
using FacadeSmartHouse.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSmartHouse.Home
{
    abstract class Room
    {
        protected AirPurifier purifier;
        protected LightBulb bulb;
        protected TemperatureHumiditySensor sensor;
        protected Plug plug;
        protected Tv tv;

        public Room()
        {
            purifier = new AirPurifier(); 
            bulb = new LightBulb();
            plug = new Plug();
            sensor = new TemperatureHumiditySensor();
            tv = new Tv();
        }
        protected abstract void DeviceActivate(BulbColor color, int channel);
         
    }
}
