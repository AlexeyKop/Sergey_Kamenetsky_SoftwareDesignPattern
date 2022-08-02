using AbstractFactory.Infrastructure;

namespace AbstractFactory.Abstractions
{
    /// <summary>
    /// Производственная линия
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// Тип модели
        /// </summary>
        public abstract Models Model { get; set; }
        /// <summary>
        /// Производство автомобиля
        /// </summary>
        /// <returns></returns>
        public abstract AbstractCar GetCar();
    }
}
