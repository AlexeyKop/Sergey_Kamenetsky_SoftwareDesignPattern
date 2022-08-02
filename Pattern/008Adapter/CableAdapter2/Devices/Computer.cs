using CableAdapter2.Data;
using CableAdapter2.Ports;

namespace CableAdapter2.Devices
{
    public class Computer
    {
        Thunderbolt3Port thunderbolt3Port;
        public Computer()
        {
            thunderbolt3Port = new Thunderbolt3Port() { Data = new DataThunderbolt() };
        }

        public Thunderbolt3Port Thunderbolt3
        {
            get { return thunderbolt3Port; }
            set { thunderbolt3Port = value; }
        }
    }

}
