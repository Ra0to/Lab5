using System;

namespace Lab5
{
    /// <summary>
    /// Система завершения игры для игрока
    /// </summary>
    class GameOverSystem : ISystem, IPlayerDeadListener
    {
        public Player Character { get; }
        private bool _isShown;

        public GameOverSystem(Player character)
        {
            Character = character;
        }

        public void Execute()
        {}

        public void OnPlayerDead(Player player)
        {
            if (Character.Id != player.Id)
                return;
            
            if (_isShown)
                return;
            
            Console.WriteLine($"Player {Character.Id} is dead, health: {Character.Health}");
            Console.WriteLine($"Game over!");
            _isShown = true;
        }
    }
}