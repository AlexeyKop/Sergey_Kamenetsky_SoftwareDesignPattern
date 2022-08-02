using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AminationFlyweight.Infrastructure
{
    static class Randomize
    {
        static readonly Random r;
        static Randomize() { r = new Random(); }
        public static int GetRandom(int max = 1000) { return r.Next(max); }
    }
}
