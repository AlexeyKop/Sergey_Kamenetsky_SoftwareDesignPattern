using CarBridge.Arguments;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBridge.BodyType
{
    public abstract class CarBodyType
    {
        readonly Options[] args;
        public CarBodyType(params Options[] arg)
        {
            args = arg;
        }
        public abstract string BodySpecification();
    }
}
