using AbstractFactory.Infrastructure;
using AbstractFactory.Kia;
using AbstractFactory.Lexus;
using AbstractFactory.Porsche;

namespace AbstractFactory
{
    //      Kia       Lexus     Porsche

    //      Rio       ES        Cayenne
    //      Ceed      NX        Panamera
    //  	Optima    RX        Macan  



    class Program
    {
        static void Main()
        {
            new Customer(new KiaFactory(), Models.KiaRio).Buy();
            new Customer(new KiaFactory(), Models.KiaCeed).Buy();
            new Customer(new KiaFactory(), Models.KiaOptima).Buy();

            new Customer(new LexusFactory(), Models.LexusES).Buy();
            new Customer(new LexusFactory(), Models.LexusNX).Buy();
            new Customer(new LexusFactory(), Models.LexusRX).Buy();

            new Customer(new PorscheFactory(), Models.PorscheCayenne).Buy();
            new Customer(new PorscheFactory(), Models.PorscheMacan).Buy();
            new Customer(new PorscheFactory(), Models.PorschePanamera).Buy();


            new Customer(new PorscheFactory(), Models.LexusRX).Buy();

        }
    }
}
