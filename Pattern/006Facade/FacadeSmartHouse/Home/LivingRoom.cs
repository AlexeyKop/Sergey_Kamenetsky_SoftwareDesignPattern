using FacadeSmartHouse.Devices;
using FacadeSmartHouse.Settings;

namespace FacadeSmartHouse.Home
{
    class LivingRoom : Room
    {
        public LivingRoom()
            : base()
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

        //public void CameHome(BulbColor color, int channel)
        //{
        //    AirPurifier purifier = new AirPurifier();
        //    purifier.Power();

        //    LightBulb bulb = new LightBulb();
        //    bulb.SetColor(color);


        //    Plug plug = new Plug();
        //    plug.TurnOn();
        //    TemperatureHumiditySensor sensor = new TemperatureHumiditySensor();
        //    sensor.GetTemperature();
        //    sensor.GetHumiditye();

        //    Tv tv = new Tv();
        //    tv.PlayChannel(channel);

        //}



    }
}
