using AbstractFactory.Abstractions;
using AbstractFactory.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AbstractFactory.Lexus
{
    /// <summary>
    /// Производственная линия автомобилей Lexus
    /// </summary>
    public class LexusFactory : Abstractions.AbstractFactory
    {
        /// <summary>
        /// Заказ автомобиля
        /// </summary>
        public LexusFactory()
        {
        }

        /// <summary>
        /// Требуемая модель Lexus
        /// </summary>
        public override Models Model { get; set; }

        /// <summary>
        /// Получение автомобиля
        /// </summary>
        /// <returns>Готовый автомобиль</returns>
        public override AbstractCar GetCar()
        {
            switch (Model)
            {
                case Models.LexusES: return new LexusES();
                case Models.LexusNX: return new LexusNX();
                case Models.LexusRX: return new LexusRX();
                default: return new UnknownCar();
            }
            
        }

 
    }
}
