using CableAdapter2.Adapters;
using CableAdapter2.Cables;
using CableAdapter2.Devices;
using System;

namespace CableAdapter2
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Было
            //Computer iMac = new Computer();
            //SoundCard apollo = new SoundCard();

            //Thunderbolt2Cable tb2Cable = new Thunderbolt2Cable();
            //apollo.Thunderbolt2 = tb2Cable.In;
            //// iMac.Thunderbolt3 = tb2Cable.Out; // Ошибка. Несоответствие интерфейсов             
            ////Thunderbolt2PortToThunderbolt3Port tb2toTb3Cable = new Thunderbolt2PortToThunderbolt3Port();

            ////tb2toTb3Cable.Thunderbolt2 = tb2Cable.Out;
            ////iMac.Thunderbolt3 = tb2toTb3Cable.Thunderbolt3;

            //// Стало v 1.1
            //Computer iMac = new Computer();
            //AdapterSoundCardToComputer apolloX = new AdapterSoundCardToComputer();

            //Thunderbolt3Cable tb3Cable = new Thunderbolt3Cable();
            //apolloX.Thunderbolt3 = tb3Cable.In;
            //iMac.Thunderbolt3 = tb3Cable.Out; // Ошибки нет. Интерфейсы подходят

            //apolloX.Thunderbolt3.Data.Signal = "++++";
            //Console.WriteLine($"apolloX.Signal: {apolloX.Thunderbolt3.Data.Signal}");
            //Console.WriteLine($"iMac.Signal: {iMac.Thunderbolt3.Data.Signal}");

            //iMac.Thunderbolt3.Data.Signal = "----";
            //Console.WriteLine($"iMac.Signal: {iMac.Thunderbolt3.Data.Signal}");
            //Console.WriteLine($"apolloX.Signal: {apolloX.Thunderbolt3.Data.Signal}");

            // Стало v 1.2
            SoundCard apollo = new SoundCard();
            AdapterComputerToSoundCard iMacPro = new AdapterComputerToSoundCard();

            Thunderbolt2Cable tb2Cable = new Thunderbolt2Cable();
            apollo.Thunderbolt2 = tb2Cable.In;
            iMacPro.Thunderbolt2 = tb2Cable.Out; // Ошибки нет. Интерфейсы подходят

            apollo.Thunderbolt2.Data.Signal = "++++";
            Console.WriteLine($"apolloX.Signal: {apollo.Thunderbolt2.Data.Signal}");
            Console.WriteLine($"iMac.Signal: {iMacPro.Thunderbolt2.Data.Signal}");

            iMacPro.Thunderbolt2.Data.Signal = "----";
            Console.WriteLine($"iMac.Signal: {iMacPro.Thunderbolt2.Data.Signal}");
            Console.WriteLine($"apolloX.Signal: {apollo.Thunderbolt2.Data.Signal}");
        }
    }
}
