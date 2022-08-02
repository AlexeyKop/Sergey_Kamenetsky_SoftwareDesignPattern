using PcFacade.Facades;
using PcFacade.Pc;

namespace PcFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            NICPc comp = new NICPc();
            // Можно прочитать инструкцию 
            // и определитиьь последовательность вызова
            comp.C0();
            comp.C1();
            comp.C3();
            comp.C6();
            comp.CF();
            comp.Step05();
            comp.Step07();
            comp.StepBE();
            comp.Step0A();
            comp.Step0B();
            comp.Step0C();
            comp.Step0D0E();
            comp.Step3031();
            comp.Step3D();
            comp.Step41();
            comp.Step45();
            comp.StepF();

            // Или так
            Facade f = new Facade(comp);
            f.Power();
            

        }
    }
}
