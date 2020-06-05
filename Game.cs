using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeExperiments
{
    public partial class Game : Form
    {
        Snake snake = null;
        
        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            snake = new Snake(this);
            snake.Render();
        }
    }
}
