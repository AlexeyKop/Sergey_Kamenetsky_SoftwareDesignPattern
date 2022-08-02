namespace AbstractFactory.Abstractions
{
    public abstract class AbstractCar
    {
        /// <summary>
        /// Логика действия происходящая после покупки
        /// </summary>
        public abstract void Run();

        /// <summary>
        /// Процесс производста кузова
        /// </summary>
        /// <returns>Готовый кузов</returns>
        protected abstract AbstractCarBody CreateCarBody();
        /// <summary>
        /// Процесс производста двигателя
        /// </summary>
        /// <returns>Готовый двигатель</returns>
        protected abstract AbstractCarEngine CreateCarEngine();
        /// <summary>
        /// Процесс производста подвески
        /// </summary>
        /// <returns>Готовая подвеска</returns>
        protected abstract AbstractCarSuspension CreateCarSuspension();
    }
}
