using CableAdapter.Cables;
using CableAdapter.Devices;
using System;

namespace CableAdapter
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Видео https://youtu.be/6mJXV9m_cmQ
            Computer iMac = new Computer();

            SoundCard apollo = new SoundCard();

            Thunderbolt2Cable tb2Cable = new Thunderbolt2Cable();

            apollo.Thunderbolt2 = tb2Cable.In;
            // iMac.Thunderbolt3 = tb2Cable.Out; // Ошибка. Несоответствие интерфейсов             
            
            Thunderbolt2PortToThunderbolt3Port tb2toTb3Cable = new Thunderbolt2PortToThunderbolt3Port();

            tb2toTb3Cable.Thunderbolt2 = tb2Cable.Out;
            iMac.Thunderbolt3 = tb2toTb3Cable.Thunderbolt3;


            apollo.Thunderbolt2.Data.Signal = "++++";
            Console.WriteLine($"apollo.Signal: {apollo.Thunderbolt2.Data.Signal}");
            Console.WriteLine($"iMac.Signal: {iMac.Thunderbolt3.Data.Signal}");

            iMac.Thunderbolt3.Data.Signal = "----";
            Console.WriteLine($"iMac.Signal: {iMac.Thunderbolt3.Data.Signal}");
            Console.WriteLine($"apollo.Signal: {apollo.Thunderbolt2.Data.Signal}");
   
        }
    }
}
