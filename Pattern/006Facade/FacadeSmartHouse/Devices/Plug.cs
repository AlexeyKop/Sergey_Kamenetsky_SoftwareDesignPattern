using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSmartHouse.Devices
{
    class Plug
    {
        private bool state;
        public Plug()
        {
            state = false;
        }
        public void TurnOn()
        { 
            state = true; 
        }
        public void TurnOff()
        {
            state = false;
        }
    }
}
