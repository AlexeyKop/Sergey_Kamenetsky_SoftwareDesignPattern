using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Porsche
{
    /// <summary>
    /// Класс описывающий производство Porsche Panamera
    /// </summary>
    public class PorschePanamera: AbstractPorscheCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public PorschePanamera() { }

        public override void Run() { Console.WriteLine($"Porsche Panamera куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new PorschePanameraBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new PorschePanameraEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new PorschePanameraSuspension(); }           
    }


}
