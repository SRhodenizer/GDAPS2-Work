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
    class Enemy
    {
        //enemy attributes to inherit
        private int health;
        private int speed;
        private int sizeX;
        private int sizeY;
        private int positionX;
        private int positionY;
        private Rectangle position;
        private bool alive;
        private Texture2D image;

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

            set { speed = value; }
        }

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
        //constructor
        public Enemy(int hp, int sp, int w, int h, int x, int y)
        {
            health = hp;
            speed = sp;
            sizeX = w;
            sizeY = h;
            positionX = x;
            positionY = y;
            position = new Rectangle(new Point(x, y), new Point(w, h));
            alive = true;
        }

        //take damage method
        public void TakeDamage(int dmg)
        {
            int finalHealth = health - dmg;
            if (finalHealth > 0)
            {
                health = finalHealth;
            }
            else if (finalHealth <= 0)
            {
                alive = false;
            }

        }

        //override draw method so it only draws alive enemies
        public void Draw(SpriteBatch spriteBatch)
        {
            if (alive == true)
            {
                spriteBatch.Draw(image);
            }
            else if (alive == false)
            {

            }
        }
    }
}
