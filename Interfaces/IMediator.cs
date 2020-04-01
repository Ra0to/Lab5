using System.Collections.Generic;

namespace Lab5
{
    /// <summary>
    /// Посредник отвечающий за передачу информации между системами
    /// </summary>
    interface IMediator
    {
        List<ISystem> Systems { get; set; }
        void InvokePlayerDead(Player player);
    }
}