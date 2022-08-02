
using PcFacade.Pc;

namespace PcFacade.Facades
{
    class Facade
    {
        NICPc pc;
        public Facade(NICPc pc)
        {
            this.pc = pc;
        }

        public void Power()
        {
            pc.C0();
            pc.C1();
            pc.C3();
            pc.C6();
            pc.CF();
            pc.Step05();
            pc.Step07();
            pc.StepBE();
            pc.Step0A();
            pc.Step0B();
            pc.Step0C();
            pc.Step0D0E();
            pc.Step3031();
            pc.Step3D();
            pc.Step41();
            pc.Step45();
            pc.StepF();
        }

    }
}
