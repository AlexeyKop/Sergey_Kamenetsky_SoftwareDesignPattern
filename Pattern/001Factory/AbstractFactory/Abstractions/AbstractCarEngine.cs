namespace AbstractFactory.Abstractions
{
    /// <summary>
    /// Класс, описывающий детали создания двигателя
    /// </summary>
    public abstract class AbstractCarEngine
    {
        /// <summary>
        /// Логика сборки двигателя
        /// </summary>
        public abstract void CreateconcreteEngine();
    }
}
