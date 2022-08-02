using FacadeSmartHouse.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FacadeSmartHouse.Home
{
    class Bedroom : Room
    {
        public Bedroom() : base()
        {

        }

        protected override void DeviceActivate(BulbColor color, int channel)
        {
            purifier.Power();

            bulb.SetColor(color);

            plug.TurnOn();

            sensor.GetTemperature();
            sensor.GetHumiditye();

            tv.PlayChannel(channel);
        }
      
        public void TurnOn()
        {
            DeviceActivate(color: BulbColor.Warm, channel: 0);
        }
    }
}
