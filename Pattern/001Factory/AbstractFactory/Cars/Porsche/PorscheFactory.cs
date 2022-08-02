using AbstractFactory.Abstractions;
using AbstractFactory.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AbstractFactory.Porsche
{
    /// <summary>
    /// Производственная линия автомобилей Porsche
    /// </summary>
    public class PorscheFactory : Abstractions.AbstractFactory
    {
        /// <summary>
        /// Заказ автомобиля
        /// </summary>
        public PorscheFactory()
        {
        }

        /// <summary>
        /// Требуемая модель Porsche
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
                case Models.PorscheCayenne: return new PorscheCayenne();
                case Models.PorscheMacan: return new PorscheMacan();
                case Models.PorschePanamera: return new PorschePanamera();
                default: return new UnknownCar();
            }
            
        }

 
    }
}
