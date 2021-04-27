using System;

namespace Enemies
{
    ///<summary>types of enemies created so far:Zombies</summary>
    class Zombie
    {
        ///name of zom
        private string name = "(No name)";
        ///health of zom
        private int health;

        ///<summary>sets HP to 0</summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary>checks inputted hp and sets it if greater than 0</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
        ///<summary>returns health</summary>
        public int GetHealth()
        {
            return health;
        }
        ///<summary>gets and sets name</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
