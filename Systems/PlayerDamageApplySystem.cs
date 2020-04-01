using System;

namespace Lab5
{
    /// <summary>
    /// Получение урона игроком
    /// </summary>
    class PlayerDamageApplySystem : ISystem
    {
        private readonly IMediator _mediator;
        private readonly int _damage;
        public Player Character { get; }

        public PlayerDamageApplySystem(Player character, IMediator mediator, int damage)
        {
            _mediator = mediator;
            _damage = damage;
            Character = character;
        }

        public void Execute()
        {
            if (Character.Health <= _damage)
            {
                Character.Health = 0;
                _mediator.InvokePlayerDead(Character);
                return;
            }

            Character.Health -= _damage;
            Console.WriteLine($"Damage player({Character.Id}), hp: {Character.Health}");
        }
    }
}