using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Porsche
{
    /// <summary>
    /// Класс описывающий производство Porsche Macan
    /// </summary>
    public class PorscheMacan: AbstractPorscheCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public PorscheMacan() { }

        public override void Run() { Console.WriteLine($"Porsche Macan куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new PorscheMacanBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new PorscheMacanEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new PorscheMacanSuspension(); }           
    }


}
