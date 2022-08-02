using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Kia
{
    /// <summary>
    /// Класс описывающий производство Kia Rio
    /// </summary>
    public class KiaRio: AbstractKiaCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public KiaRio() { }

        public override void Run() { Console.WriteLine($"Kia Rio куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new KiaRioBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new KiaRioEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new KiaRioSuspension(); }           
    }


}
