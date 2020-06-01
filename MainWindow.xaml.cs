using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SnakeGame
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isStart = false;
        bool isFail = false;
        DispatcherTimer timer=new System.Windows.Threading.DispatcherTimer();
        Snake snake;
        SnakeDirection snakeDirection;
        Food food;

        public MainWindow()
        {
            InitializeComponent();
            DrawGrid();
            Rectangle myRectangle = new Rectangle();
            myRectangle.Name = "myRectangle";
            this.RegisterName(myRectangle.Name, myRectangle);
            myRectangle.Width = 25;
            myRectangle.Height = 25;
            myRectangle.Fill = Brushes.Blue;
            MainPanel.Children.Add(myRectangle);

            Init();
            MainPanel.Focusable = true;
        }

        private void Init()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 400);
            timer.Tick += Timer_Tick;
            snake = new Snake();
            snakeDirection = SnakeDirection.Right;

            food = new Food();

        }

        private void MainPanel_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Key keyCode = e.Key;
            if (Key.Space == keyCode)
            {
                if (isFail)
                {
                    isFail = false;
                    Init();
                }
                else
                {
                    isStart = !isStart;
                }
            }
            if (Key.Left == keyCode)
            {
                if (SnakeDirection.Right == snakeDirection)
                {
                    isFail = true;
                }
                else
                {
                    snakeDirection = SnakeDirection.Left;
                }
            }
            else if (Key.Right == keyCode)
            {
                if (SnakeDirection.Left == snakeDirection)
                {
                    isFail = true;
                }
                else
                {
                    snakeDirection = SnakeDirection.Right;
                }
            }
            else if (Key.Up == keyCode)
            {
                if (SnakeDirection.Down == snakeDirection)
                {
                    isFail = true;
                }
                else
                {
                    snakeDirection = SnakeDirection.Up;
                }
            }
            else if (Key.Down == keyCode)
            {
                if (SnakeDirection.Up == snakeDirection)
                {
                    isFail = true;
                }
                else
                {
                    snakeDirection = SnakeDirection.Down;
                }
            }
            //repaint();
        }
        public void Cancel()
        {
            this.Close();
        }


        private void DrawGrid()
        {
            Path gridPath = new Path();
            gridPath.Stroke = new SolidColorBrush(Color.FromArgb(255, 50, 50, 50));
            gridPath.StrokeThickness = 1;

            StringBuilder data = new StringBuilder();

            for (int x = 0; x <= 850; x += 25)
            {
                data.Append($"M{x},0 L{x},600 ");
            }

            for (int y = 0; y <= 600; y += 25)
            {
                data.Append($"M0,{y} 850,{y} ");
            }

            gridPath.Data = Geometry.Parse(data.ToString());
            MainPanel.Children.Add(gridPath);
        }
    }
}
