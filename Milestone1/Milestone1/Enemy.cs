using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone1
{
    class Enemy 
    {
        //enemy attributes to inherit
        private int health;
        private int speed;
        private int sizeX;
        private int sizeY;

      //properties for attributes
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

        public int Speed
        {
            get { return speed; }
        }

        public int SizeX
        {
            get { return sizeX; }
        }

        public int SizeY
        {
            get { return sizeY; }
        }

        //constructor
        public Enemy(int hp, int sp, int x, int y)
        {
            health = hp;
            speed = sp;
            sizeX = x;
            sizeY = y;
        }

    }
}
