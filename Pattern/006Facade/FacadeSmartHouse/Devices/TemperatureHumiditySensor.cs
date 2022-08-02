using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSmartHouse.Devices
{
    class TemperatureHumiditySensor
    {
        private int TemperatureData()
        {
            return new Random(Guid.NewGuid().GetHashCode()).Next(10, 30);
        }

        private int HumidityData()
        {
            return new Random(Guid.NewGuid().GetHashCode()).Next(30, 99);
        }
        public string GetTemperature()
        {
            return $"{TemperatureData()} ℃";
        }

        public string GetHumiditye()
        {
            return $"{HumidityData()} %";
        }
    }
}
