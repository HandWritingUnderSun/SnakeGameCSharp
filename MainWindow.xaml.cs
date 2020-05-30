using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnakeGame
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Init();
            Focus(this);
            this.setFocusable(true);

            this.addKeyListener(this);
            timer.start();
        }

        private void Init()
        {
            timer = new Timer(300, this);
            snake = new Snake();
            snakeDirection = SnakeDirection.Right;

            food = new Food();

        }


        public void Cancel()
        {
            this.Close();
        }
    }
}
