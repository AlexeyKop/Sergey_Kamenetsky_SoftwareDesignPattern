using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder.Builder
{
    class Engineer
    {
        public AbstractBuilder MainBuilder { get; set; }
        public Engineer(AbstractBuilder builder) { this.MainBuilder = builder; }

        public void Produce()
        {
            Console.WriteLine($"Работает {MainBuilder}");

            MainBuilder.MakeSuspension(); 
            MainBuilder.MakeEngine();
            MainBuilder.MakeBody();
        }
    }
}
