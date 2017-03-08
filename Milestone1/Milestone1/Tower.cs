using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Milestone1
{
    class Tower
    {

        //enemy attributes to inherit
        private int sizeX;
        private int sizeY;
        private int positionX;
        private int positionY;
        private Rectangle position;
        private int rangeX;
        private int rangeY;
        private Rectangle range;
        private int damage;
        private bool alive;
        private Texture2D image;

        //properties for attributes
        public int SizeX
        {
            get { return sizeX; }
        }

        public int SizeY
        {
            get { return sizeY; }
        }

        public int PositionX
        {
            get { return positionX; }

            set { positionX = value; }
        }

        public int PositionY
        {
            get { return positionY; }

            set { positionY = value; }
        }

        public Rectangle Position
        {
            get { return position; }

            set { position = value; }
        }

        public int RangeX
        {
            get { return rangeX; }
        }

        public int RangeY
        {
            get { return rangeY; }
        }

        public Rectangle Range
        {
            get { return range; }
        }

        public int Damage
        {
            get { return damage; }

        }
        //constructor
        public Tower(int w, int h, int x, int y, int rX, int rY, int dmg)
        {

            sizeX = w;
            sizeY = h;
            positionX = x;
            positionY = y;
            position = new Rectangle(new Point(x, y), new Point(w, h));
            rangeX = rX;
            rangeY = rY;
            range = new Rectangle(new Point(x, y), new Point(rX, rY));
            damage = dmg;
        }

        //attack method - returns damage dealt as an int
        public int Attack(Rectangle enemyPos)
        {
            if (range.Intersects(enemyPos) == true)
            {
                return damage;
            }
            else
            {
                return 0;
            }
        }
    }
}
