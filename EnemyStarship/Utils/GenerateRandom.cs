using System;

namespace EnemyStarship.Utils
{
    /// <summary>
    /// This Class can be used to generate random numbers for things like:
    ///     - hit damage dealt/taken
    ///     - Starship Speed for different states
    ///     - whether a spaceship randomly regenerates it's shield
    ///     - whether a projectile makes a hit
    ///     - whether or not a projectile hits the Enemy Ship
    ///     - etc.
    /// </summary>
    public class RandomGenerator
    {
        /// <summary>
        /// Overloaded Method: Generate
        /// </summary>
        /// <param name="min">int, defaulted to 0</param>
        /// <param name="max">int, defaulted to 10</param>
        /// <returns>int between min max values</returns>
        public int Generate(int min = 0, int max = 10){
            Random RandNum = new Random();
            return RandNum.Next(min, max);
        }


        /// <summary>
        /// Overloaded Method: Generate
        /// </summary>
        /// <param name="min">double, defaulted to 0</param>
        /// <param name="max">double, defaulted to 10</param>
        /// <returns>double between min max values</returns>
        public double Generate(double min = 0, double max = 10){
            Random RandNum = new Random();
            return RandNum.NextDouble() * (max - min) + min;
        }
    }
}