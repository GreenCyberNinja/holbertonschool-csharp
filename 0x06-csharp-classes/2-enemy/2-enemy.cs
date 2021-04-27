﻿using System;

namespace Enemies
{
    ///<summary>types of enemies created so far:Zombies</summary>
    class Zombie
    {
        ///<summary>health of zom</summary>
        public int health;

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
    }
}
