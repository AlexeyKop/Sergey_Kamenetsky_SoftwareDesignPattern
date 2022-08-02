using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Kia
{
    /// <summary>
    /// Класс описывающий производство Kia Optima
    /// </summary>
    public class KiaOptima: AbstractKiaCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public KiaOptima() { }

        public override void Run() { Console.WriteLine($"Kia Optima куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new KiaOptimaBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new KiaOptimaEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new KiaOptimaSuspension(); }           
    }


}
