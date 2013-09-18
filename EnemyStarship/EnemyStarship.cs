using System;
using EnemyStarship.Utils;
using EnemyStarship.ShipStates;

namespace EnemyStarship
{ 
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class EnemyStarship
    {
        private State _state;

        public EnemyStarship(int shipHealth)
        {
            //all ships start off with a shield
            Console.WriteLine("\n\n--- Enemy Starship Appears in view. ---");
            this._state = new Shielded(shipHealth, this);
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void TakeRocketHit()
        {
            Console.WriteLine("\nEnemy Ship hit by Rocket.");
            _state.TakeRocketHit();
            _state.StateChangeCheck();
        }

        public void TakeLaserHit()
        {
            Console.WriteLine("\nEnemy Ship hit by Laser.");
            _state.TakeLaserHit();
            _state.StateChangeCheck();
        }
    }
}
