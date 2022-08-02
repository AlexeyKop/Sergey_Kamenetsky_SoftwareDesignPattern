using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Porsche
{
    /// <summary>
    /// Класс описывающий производство Porsche Cayenne
    /// </summary>
    public class PorscheCayenne: AbstractPorscheCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public PorscheCayenne() { }

        public override void Run() { Console.WriteLine($"Porsche Cayenne куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new PorscheCayenneBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new PorscheCayenneEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new PorscheCayenneSuspension(); }           
    }


}
