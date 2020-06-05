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
        private Form gameForm;

        public Snake(Form form)
        {
            InitializeSnake();
            gameForm = form;
        }

        private void InitializeSnake()
        {
            AddPixel(200, 200);
            AddPixel(220, 200);
            AddPixel(240, 200);
            AddPixel(240, 220);
            AddPixel(240, 240);
            AddPixel(240, 260);
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
                gameForm.Controls.Add(sp);
            }
        }
    }
}
