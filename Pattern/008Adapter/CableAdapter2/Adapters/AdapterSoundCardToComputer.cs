using CableAdapter2.Data;
using CableAdapter2.Devices;
using CableAdapter2.Ports;
using System;
using System.Collections.Generic;
using System.Text;

namespace CableAdapter2.Adapters
{
    public class AdapterSoundCardToComputer
    {
        SoundCard soundCard;
        Thunderbolt3Port thunderbolt3;
        public AdapterSoundCardToComputer()
        {
            soundCard = new SoundCard();
            thunderbolt3 = new Thunderbolt3Port() { Data = new DataThunderbolt() };
        }

        public Thunderbolt3Port Thunderbolt3
        {
            get 
            { 
                thunderbolt3.Data = soundCard.Thunderbolt2.Data; 
                return thunderbolt3; 
            }
            set 
            { 
                thunderbolt3 = value;
                soundCard.Thunderbolt2.Data = value.Data;
            }
        }
    }

    public class AdapterComputerToSoundCard
    {
        Computer iMac;
        Thunderbolt2Port thunderbolt2;
        public AdapterComputerToSoundCard()
        {
            iMac = new Computer();
            thunderbolt2 = new Thunderbolt2Port() { Data = new DataThunderbolt() };
        }

        public Thunderbolt2Port Thunderbolt2
        {
            get
            {
                thunderbolt2.Data = iMac.Thunderbolt3.Data;
                return thunderbolt2;
            }
            set
            {
                thunderbolt2 = value;
                iMac.Thunderbolt3.Data = value.Data;
            }
        }

    }

}
