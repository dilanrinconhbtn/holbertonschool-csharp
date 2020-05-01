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
        private string name = "(No name)";
        /// <summary> 
        ///private class Zombie 
        ///</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary> 
        ///private class Zombie value int
        ///</summary>
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
        /// <summary> 
        ///private class Get health
        ///</summary>
        public int GetHealth()
        {
            return health;
        }
        /// <summary> 
        ///private Name 
        ///</summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
        /// <summary> 
        ///private override Tostring
        ///</summary>
        public override string ToString()
        {
            return String.Format("Zombie Name: {0} / Total Health: {1}",name,health);
        }
    }
}
