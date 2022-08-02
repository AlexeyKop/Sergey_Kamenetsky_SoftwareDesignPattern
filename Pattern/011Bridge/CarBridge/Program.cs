using CarBridge.Aktiengesellschaft;
using CarBridge.Aktiengesellschaft.Audi;
using CarBridge.Aktiengesellschaft.Bugatti;
using CarBridge.Aktiengesellschaft.PorscheAG;
using CarBridge.BodyType;
using static System.Console;

namespace CarBridge
{
    class Program
    {
        static void Main()
        {
            // Видео https://youtu.be/ePbId3gENRo
            WriteLine(new AudiRS4(new Sedan()));
            WriteLine(new AudiRS5(new Sedan()));
            WriteLine(new AudiRS5(new Sportback()));
            WriteLine(new Etron(new Electric()));
            WriteLine(new PorscheMacan(new SUV()));
        }
    }
}
