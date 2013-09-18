using System;

namespace EnemyStarship.ShipStates
{
    //Derived from base class(State.cs); this is subclass
    class UnShielded : State
    {
        public UnShielded(State state)
        {
            Console.WriteLine("\nEnemy shield has dropped!!\n");
            this.ShipHealth = state.ShipHealth;
            this.EnemyStarship = state.EnemyStarship;
        }

        /* override virtual member of base class to do further 
         * damage when Enemy Starship drops shield */
        public override void TakeLaserHit()
        {
            CalculateDamage(35);
            this.StateChangeCheck();
        }


        public override void StateChangeCheck()
        {
            this._StateChangeCheck();
        }

        //state changes to DestructionStarburst upon destruction
        private void _StateChangeCheck()
        {
            if (this.ShipHealth <= 0)
            {
                EnemyStarship.State = new DestructionStarBurst(this);
            }
        }
    }
}
