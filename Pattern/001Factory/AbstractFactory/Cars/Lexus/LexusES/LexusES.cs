using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Lexus
{
    /// <summary>
    /// Класс описывающий производство Lexus ES
    /// </summary>
    public class LexusES: AbstractLexusCar
    {
        /// <summary>
        /// <para>Вариативно, при создании можно определить</para> 
        /// <para>тип кузова</para>
        /// <para>объём двигателя</para> 
        /// <para>другие параметры </para>
        /// </summary>
        public LexusES() { }

        public override void Run() { Console.WriteLine($"Lexus ES куплена"); }
        protected override AbstractCarBody CreateCarBody() { return new LexusESBody(); }
        protected override AbstractCarEngine CreateCarEngine() { return new LexusESEngine(); }
        protected override AbstractCarSuspension CreateCarSuspension() { return new LexusESSuspension(); }           
    }


}
