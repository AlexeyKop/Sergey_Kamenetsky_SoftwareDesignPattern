using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Kia
{
    /// <summary>
    /// Класс описывающий производство Kia Ceed
    /// </summary>
    public class KiaCeed: AbstractKiaCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public KiaCeed() { }

        public override void Run() { Console.WriteLine($"Kia Ceed куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new KiaCeedBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new KiaCeedEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new KiaCeedSuspension(); }           
    }


}
