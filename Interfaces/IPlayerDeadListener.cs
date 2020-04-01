namespace Lab5
{
    /// <summary>
    /// Слушатель события о смерти игрока 
    /// </summary>
    interface IPlayerDeadListener
    {
        void OnPlayerDead(Player player);
    }
}