namespace FacadeSmartHouse.Devices
{
    class AirPurifier
    {
        bool enable;
        public AirPurifier()
        {
            enable = false;
        }

        public void Power()
        {
            enable = !enable;
        }
    }
}
