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
    public partial class Game : Form //inherits from From class
    {
        private Snake snake = null;
        private Timer mainTimer = null;
        
        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeMainTimer();
        }

        private void InitializeMainTimer()
        {
            mainTimer = new Timer();
            mainTimer.Interval = 500;
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            snake.Move();
        }

        private void InitializeGame()
        {
            snake = new Snake(this);
            snake.Render();
            snake.ChangeDirection(0);
        }
    }
}
