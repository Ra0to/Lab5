namespace Lab5
{
    /// <summary>
    /// Выполняемые системы
    /// </summary>
    interface ISystem
    {
        /// <summary>
        /// Владелец системы
        /// </summary>
        Player Character { get; }
        
        void Execute();
    }
}