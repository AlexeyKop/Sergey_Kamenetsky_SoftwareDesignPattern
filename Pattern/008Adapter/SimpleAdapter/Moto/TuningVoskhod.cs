using SimpleAdapter.Interfaces;
using static System.Console;

namespace SimpleAdapter.Moto
{
    /// Адаптер.
    /// Адаптирует простой класс под цель
    class TuningVoskhod : ISport
    {
        readonly Voskhod moto;
        public TuningVoskhod(Voskhod moto) => this.moto = moto;

        public void MakeNoise()
        {
            WriteLine("trsh trsh ");
            moto.Sound();
        }
    }
}
