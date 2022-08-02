using PcComposite.Units.Nodes;
using PcComposite.Units.Nodes.CommonUnits;
using PcComposite.Units.Nodes.CPUNodes;
using PcComposite.Units.Nodes.MotherboardNodes;
using PcComposite.Units.Nodes.PowerSupplyNodes;
using PcComposite.Units.Nodes.RAMNodes;
using PcComposite.Units.VideoCardNodes;
using System;

namespace PcComposite
{
    class Program
    {
        static void Main()
        {

            CPU cpu = new CPU("Intel 100100K");
            cpu.Add(new ArithmeticLogicUnit(), new ProcessorRegister());

            Motherboard motherboard = new Motherboard("Gigabyte z37811");
            PCIExpress pciEx = new PCIExpress();
            pciEx.Add(new ElectricalWiring("10 pin"), new ElectricalWiring("10 pin"));
            motherboard.Add(new MCA(), pciEx, new ElectricalWiring("18 pin"));

            PowerSupply powerSupply = new PowerSupply("THERMALTAKE LT-1650P");
            powerSupply.Add(
            new ElectricalWiring("18 pin"),
            new ElectricalWiring("10 pin"),
            new ElectricalWiring("8 pin"),
            new ElectricalWiring("6 pin"),
            new ElectricalWiring("8 pin"),
            new ElectricalWiring("6 pin"),
            new ElectricalWiring("4 pin")
            );

            RAM ram = new RAM("DDR4 HPE 123456-B21 32Gb");

            VideoCard videoCard = new VideoCard("gtx 4090ti");

            Computer myComputer = new Computer("Мой компьютер");

            myComputer.Add(powerSupply, motherboard, videoCard, cpu, ram, new ElectricalWiring("24 pin"));

            myComputer.Build();


        }
    }
}
