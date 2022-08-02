using CableAdapter2.Data;
using CableAdapter2.Ports;

namespace CableAdapter2.Cables
{
    public class Thunderbolt3Cable
    {
        public Thunderbolt3Cable()
        {
            data = new Thunderbolt3Port() { Data = new DataThunderbolt() };
        }
        Thunderbolt3Port data;

        public Thunderbolt3Port In { get { return data; } set { data = value; } }
        public Thunderbolt3Port Out { get { return data; } set { data = value; } }
    }
}
