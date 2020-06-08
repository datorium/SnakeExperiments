using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeExperiments
{
    class Food: PictureBox
    {

        private Form game = null;
        public Food(Form gameForm)
        {
            game = gameForm;
            InitializeFood();
        }

        public void Render()
        {
            game.Controls.Add(this);
        }

        private void InitializeFood()
        {
            this.BackColor = Color.LimeGreen;
            this.Width = 20;
            this.Height = 20;
            this.Location = new Point(80, 80);
        }

    }


}
