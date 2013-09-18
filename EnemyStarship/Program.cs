using System;

namespace EnemyStarship
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fire two rockets at
            EnemyStarship FrigateFighter = new EnemyStarship(150);
            while (FrigateFighter.State.ShipHealth > 0) {
                FrigateFighter.TakeRocketHit();
            }

            // Shoot ship with 1 Rocket and then Laser it to destruction state
            EnemyStarship SilverHawk = new EnemyStarship(100);
            SilverHawk.TakeRocketHit();
            while (SilverHawk.State.ShipHealth > 0)
            {
                SilverHawk.TakeLaserHit();
            }

            // Simply Laser the ship to destruction
            EnemyStarship Scout = new EnemyStarship(80);
            while (Scout.State.ShipHealth > 0)
            {
                Scout.TakeLaserHit();
            }

            Console.ReadKey();
        }
    }
}
