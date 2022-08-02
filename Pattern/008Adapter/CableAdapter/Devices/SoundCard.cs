using CableAdapter.Ports;

namespace CableAdapter.Devices
{
    public class SoundCard
    {
        Thunderbolt2Port thunderbolt2Port;
        public SoundCard()
        {
            thunderbolt2Port = new Thunderbolt2Port();
        }
        public Thunderbolt2Port Thunderbolt2
        {
            get { return thunderbolt2Port; }
            set { thunderbolt2Port = value; }
        }
    }
}
