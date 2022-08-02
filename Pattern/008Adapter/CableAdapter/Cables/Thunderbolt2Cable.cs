using CableAdapter.Data;
using CableAdapter.Ports;

namespace CableAdapter.Cables
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
