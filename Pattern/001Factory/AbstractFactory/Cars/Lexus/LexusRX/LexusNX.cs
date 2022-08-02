using AbstractFactory.Abstractions; using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Lexus
{
    /// <summary>
    /// Класс описывающий производство Lexus RX
    /// </summary>
    public class LexusRX: AbstractLexusCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public LexusRX() { }

        public override void Run() { Console.WriteLine($"Lexus RX куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new LexusRXBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new LexusRXEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new LexusRXSuspension(); }           
    }


}
