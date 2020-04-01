using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        static List<ISystem> SystemsConstructor(Player player, IMediator mediator, int damage)
        {
            var moveSystem = new PlayerMoveSystem(player);
            var damageSystem = new PlayerDamageApplySystem(player, mediator, damage);
            var gameOverSystem = new GameOverSystem(player);

            return new List<ISystem>() {moveSystem, damageSystem, gameOverSystem}; 
        }
        
        static void Main(string[] args)
        {
            var player = new Player("@-1");
            var player2 = new Player("@0");
            
            var mediator = new Mediator();
            mediator.Systems = SystemsConstructor(player, mediator, 21);
            mediator.Systems.InsertRange(0, SystemsConstructor(player2, mediator, 10));

            for (var i = 0; i < 100 && (player.IsAlive || player2.IsAlive); i++)
            {
                foreach (var system in mediator.Systems)
                    system.Execute();
            }
        }
    }
}