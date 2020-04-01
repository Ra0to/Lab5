using System;
using System.Numerics;

namespace Lab5
{
    /// <summary>
    /// Система отвещающая за движение персонажа в пространстве
    /// </summary>
    class PlayerMoveSystem : ISystem, IPlayerDeadListener
    {
        public Player Character { get; }
        private bool _canMove;

        public PlayerMoveSystem(Player character)
        {
            Character = character;
            Character.Velocity = new Vector2(1f, 0f);
            _canMove = character.IsAlive;
        }

        public void Execute()
        {
            if (!_canMove)
                return;

            Character.Position += Character.Velocity;
            Console.WriteLine($"Player({Character.Id}) position: {Character.Position}");
        }

        public void OnPlayerDead(Player player)
        {
            if (player.Id != Character.Id)
                return;
            
            if (!_canMove)
                return;
            
            _canMove = false;
            Character.Velocity = Vector2.Zero;
            Console.WriteLine($"Stop player({Character.Id})!");
        }
    }
}