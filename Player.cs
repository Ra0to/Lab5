using System.Numerics;

namespace Lab5
{
    /// <summary>
    /// Характеристики пероснажа
    /// </summary>
    class Player
    {
        public string Id;

        public int Health;
        public bool IsAlive => Health > 0f;

        public Vector2 Position;
        public Vector2 Velocity;

        public Player(string id)
        {
            Id = id;
            Health = 100;
            Position = Vector2.Zero;
            Velocity = Vector2.Zero;
        }
    }
}