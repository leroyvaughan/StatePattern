using System;
using EnemyStarship.Utils;

namespace EnemyStarship
{
    /// <summary>
    /// This is StateBasel used by the Context object (EnemyStarship)
    /// No state is defined in this class or the subclasses, 
    /// it is defined by the Context object
    /// </summary>
    public abstract class State
    {
        //The Enemy Starships can be enhanced with these:
        protected string hullColor;
        protected double shipSpeed;

        public EnemyStarship EnemyStarship{ get; set; }
        public int ShipHealth{ get; set; }

        //these are optionally overidden in the subclass
        public virtual void TakeRocketHit() { CalculateDamage(50); }
        public virtual void TakeLaserHit() { CalculateDamage(25); }

        public virtual void CalculateDamage(int damage)
        {
            Console.WriteLine("\t{0} Damage Dealt", damage);
            this.ShipHealth = this.ShipHealth - damage;
            Console.WriteLine("\tEnemy Health: {0}", this.ShipHealth);
        }

        public virtual void StateChangeCheck(){}
    }
}
