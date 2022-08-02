using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Lexus
{
    /// <summary>
    /// Класс описывающий производство Lexus NX
    /// </summary>
    public class LexusNX: AbstractLexusCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public LexusNX() { }

        public override void Run() { Console.WriteLine($"Lexus NX куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new LexusNXBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new LexusNXEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new LexusNXSuspension(); }           
    }


}
