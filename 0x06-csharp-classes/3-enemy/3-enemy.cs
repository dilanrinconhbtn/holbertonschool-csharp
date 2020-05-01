using System;

namespace Enemies
{
    /// <summary>
    /// This class Zombie does something.
    /// </summary>
    class Zombie
    {
        /// <summary> 
        ///public field health = 0 
        ///</summary>
        private int health;
        /// <summary> 
        ///private class Zombie 
        ///</summary>
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if(value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
        public int GetHealth()
        {
            return health;
        }
    }
}
