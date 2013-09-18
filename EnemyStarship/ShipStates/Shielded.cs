using System;

namespace EnemyStarship.ShipStates
{
    public class Shielded : State
    {
        // Overloaded Constructor Method for Shield Re-Generation
        public Shielded(State state)
            : this(state.ShipHealth, state.EnemyStarship)
        { }

        // Overloaded Constructor Method for Initialization
        public Shielded(int shipHealth, EnemyStarship enemyStarship)
        {
            Console.WriteLine("Shields are up.");
            this.ShipHealth = shipHealth;
            this.EnemyStarship = enemyStarship;
            Console.WriteLine("Ship Health: {0}", this.ShipHealth);
        }


        public override void StateChangeCheck(){
            this._StateChangeCheck();
        }

        //state changes to Unshielded when health less than 75
        private void _StateChangeCheck()
        {
            if (this.ShipHealth < 75)
            {
                EnemyStarship.State = new UnShielded(this);
            }
        }
    }
}
