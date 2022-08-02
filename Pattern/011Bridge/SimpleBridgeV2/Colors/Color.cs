using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBridgeV2.Colors
{
    class Color
    {
        protected string color;
        protected Color(string color) => this.color = color;
        public override string ToString() => color;
    }
}
