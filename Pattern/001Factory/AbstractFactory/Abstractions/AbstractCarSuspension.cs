namespace AbstractFactory.Abstractions
{
    /// <summary>
    /// Класс, описывающий детали создания подвески
    /// </summary>
    public abstract class AbstractCarSuspension
    {
        /// <summary>
        /// Логика сборки подвески
        /// </summary>
        public abstract void CreateSuspension();
    }
}
