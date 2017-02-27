using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone1
{
    class Tower
    {
        //attributes
        private int health;
        private int range;
        private int damage;

        //properties
        public int Health
        {
            get { return health; }

            set
            {
                if (value < health && value > 0)
                {
                    health = value;
                }
            }
        }

        public int Range
        {
            get { return range; }
        }

        public int Damage
        {
            get { return damage; }
        }

        //constructor 
        public Tower(int hp, int rg, int dmg)
        {
            health = hp;
            range = rg;
            damage = dmg;
        }


    }
}
