using AbstractFactory.Abstractions;
using AbstractFactory.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AbstractFactory.Kia
{
    /// <summary>
    /// Производственная линия автомобилей Kia
    /// </summary>
    public class KiaFactory : Abstractions.AbstractFactory
    {
        /// <summary>
        /// Заказ автомобиля
        /// </summary>
        public KiaFactory()
        {
        }

        /// <summary>
        /// Требуемая модель Kia
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
                case Models.KiaRio: return new KiaRio();
                case Models.KiaCeed: return new KiaCeed();
                case Models.KiaOptima: return new KiaOptima();
                default: return new UnknownCar();
            }
            
        }

 
    }
}
