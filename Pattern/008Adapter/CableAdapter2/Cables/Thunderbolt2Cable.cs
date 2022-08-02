using CableAdapter2.Data;
using CableAdapter2.Ports;

namespace CableAdapter2.Cables
{
    public class Thunderbolt2Cable
    {
        public Thunderbolt2Cable()
        {
            data = new Thunderbolt2Port() { Data = new DataThunderbolt() };
        }
        Thunderbolt2Port data;

        public Thunderbolt2Port In { get { return data; } set { data = value; } }
        public Thunderbolt2Port Out { get { return data; } set { data = value; } }
    }
}
