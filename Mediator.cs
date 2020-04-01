using System.Collections.Generic;

namespace Lab5
{
    class Mediator : IMediator
    {
        public List<ISystem> Systems { get; set; }

        public Mediator(List<ISystem> systems)
        {
            Systems = systems;
        }

        public Mediator() {}

        public void InvokePlayerDead(Player player)
        {
            foreach (var system in Systems)
            {
                if (system is IPlayerDeadListener deadListener)
                    deadListener.OnPlayerDead(player);
            }
        }
    }
}