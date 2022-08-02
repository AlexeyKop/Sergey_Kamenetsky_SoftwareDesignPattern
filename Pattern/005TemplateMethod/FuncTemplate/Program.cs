using FuncTemplate.Computers;
using FuncTemplate.Infrastructure;

namespace FuncTemplate
{
    class Program
    {
        static void Main(string[] args)
        {

            // видео https://youtu.be/J4mD4mkTbog
            Mac air = new Mac();
            Computer.Run(air.PowerOn, air.Power, air.Rendering, air.PowerOff);

            Pc pc = new Pc();
            Computer.Run(pc.PowerOn, pc.Power, pc.PlayDota, null);
        }
    }
}