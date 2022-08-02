using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSmartHouse.Devices
{
    class Tv
    {
        private bool state;
        public Tv()
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
        public void PlayChannel(params int[] args)
        {

        }
    }
}
