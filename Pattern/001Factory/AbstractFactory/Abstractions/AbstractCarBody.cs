namespace AbstractFactory.Abstractions
{
    /// <summary>
    /// Класс, описывающий детали создания кузова
    /// </summary>
    public abstract class AbstractCarBody
    {
        /// <summary>
        /// Логика сборки кузова
        /// </summary>
        public abstract void CreateBody();
    }
}
