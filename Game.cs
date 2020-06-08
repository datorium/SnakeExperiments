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
        private Food food = null;
        private Timer mainTimer = null;

        private Random rand = new Random();
        
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
            SnakeFoodCollision();
        }

        private void InitializeGame()
        {
            this.KeyDown += new KeyEventHandler(Game_KeyDown);

            snake = new Snake(this);
            snake.Render();
            snake.ChangeDirection(0);

            food = new Food(this);
            food.Render();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    snake.ChangeDirection(0);
                    break;
                case Keys.Down:
                    snake.ChangeDirection(90);
                    break;
                case Keys.Left:
                    snake.ChangeDirection(180);
                    break;
                case Keys.Up:
                    snake.ChangeDirection(270);
                    break;
            }
        }

        private void SnakeFoodCollision()
        {
            if (food.Bounds.IntersectsWith(snake.snakePixels[0].Bounds))
            {
                RegenerateFood();
                mainTimer.Interval -= 20;
            }
        }

        private void SnakeFoodWholeBodyCollision()
        {
            foreach (var sp in snake.snakePixels)
            {
                if (food.Bounds.IntersectsWith(sp.Bounds))
                {
                    RegenerateFood();
                }
            }
        }

        private void RegenerateFood()
        {
            food.Left = rand.Next(0, 20) * 20;
            food.Top = rand.Next(0, 20) * 20;
            SnakeFoodWholeBodyCollision();
        }

    }
}
