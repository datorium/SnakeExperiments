using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeExperiments
{

    class Snake
    {
        private List<PictureBox> snakePixels = new List<PictureBox>();
        private Form game;

        private int speed = 20;
        private int horVelocity  = 0;
        private int verVelocity = 0;
        private int direction = 0; //0(right), 90(down), 180(left), 270(up)

        public Snake(Form form)
        {
            InitializeSnake();
            game = form;
        }

        private void InitializeSnake()
        {
            for(int i = 1; i <= 1; i++)
            {
                AddPixel(40, i * 20);
            }
        }

        public void AddPixel(int left, int top)
        {
            PictureBox sp = new PictureBox()
            {
                BackColor = Color.Blue,
                Height = 20,
                Width = 20,
                Left = left,
                Top = top
            };
            snakePixels.Add(sp);
        }


        public void Render()
        {
            foreach(var sp in snakePixels)
            {
                game.Controls.Add(sp);
            }
        }

        public void ChangeDirection(int snakeDirection)
        {
            direction = snakeDirection;
            switch (direction)
            {
                case 0:
                    horVelocity = speed;
                    verVelocity = 0;
                    break;
                case 90:
                    horVelocity = 0;
                    verVelocity = speed;
                    break;
                case 180:
                    horVelocity = -speed;
                    verVelocity = 0;
                    break;
                case 270:
                    horVelocity = 0;
                    verVelocity = -speed;
                    break;
            }
        }

        public void Move()
        {
            snakePixels[0].Left += horVelocity;
            snakePixels[0].Top += verVelocity;  
        }
    }
}
