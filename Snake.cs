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
    }
}
