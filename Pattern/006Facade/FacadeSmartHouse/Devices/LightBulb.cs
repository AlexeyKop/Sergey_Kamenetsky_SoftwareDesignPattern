using FacadeSmartHouse.Settings;

namespace FacadeSmartHouse.Devices
{
    class LightBulb
    {
        BulbColor color;
        public LightBulb() { }

        public void SwitchOff() { }

        public void SetColor(BulbColor color)
        {
            this.color = color;
        }
    }
}
