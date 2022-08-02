using FacadeSmartHouse.Devices;
using FacadeSmartHouse.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSmartHouse.Facade
{
    class FacadeRoom
    {
        AirPurifier purifier;
        LightBulb bulb;
        TemperatureHumiditySensor sensor;
        Plug plug;
        Tv tv;

        public void DeviceActivate(BulbColor color, int channel)
        {
            purifier.Power();

            bulb.SetColor(color);

            plug.TurnOn();

            sensor.GetTemperature();
            sensor.GetHumiditye();

            tv.PlayChannel(channel);
        }
    }
}
