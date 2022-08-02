using CableAdapter.Data;
using CableAdapter.Ports;

namespace CableAdapter
{
    // Почти адаптер

    public class Thunderbolt2PortToThunderbolt3Port
    {
        private Thunderbolt2Port thunderbolt2Port;
        private Thunderbolt3Port thunderbolt3Port;

        public Thunderbolt2PortToThunderbolt3Port()
        {
            thunderbolt2Port = new Thunderbolt2Port() { Data = new DataThunderbolt() };
            thunderbolt3Port = new Thunderbolt3Port() { Data = new DataThunderbolt() };
        }
        public Thunderbolt3Port Thunderbolt3
        {
            get { return thunderbolt3Port; }
            set { thunderbolt2Port.Data = value.Data; }
        }

        public Thunderbolt2Port Thunderbolt2
        {
            get { return thunderbolt2Port; }
            set { thunderbolt3Port.Data = value.Data; }
        }
    }
}
