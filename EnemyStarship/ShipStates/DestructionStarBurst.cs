using System;

namespace EnemyStarship.ShipStates
{
    public class DestructionStarBurst : State
    {
        //3rd state of the enemy starship; Ship state is the passed param
        public DestructionStarBurst(State state) : 
            this(state.ShipHealth, state.EnemyStarship) { }

        public DestructionStarBurst(int shipHealth, EnemyStarship enemyStarship)
        {
            Console.WriteLine("\nEnemy Starship bursts into flames and debris!!");
            if(shipHealth < 0){
                Console.WriteLine("\tDirect Hit! Overkill! Bonus 50 pts.");
            }

            enemyStarship = null;

            /*  more code could go here:
                    - (implied code) possible UI to show ship blowing up
                    - (implied code) destroy enemy object
                    - (implied code) add points to the board
            */
        }
    }
}
