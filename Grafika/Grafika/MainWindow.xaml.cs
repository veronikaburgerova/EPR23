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

namespace Grafika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drawSquares(6, 20);
        }

        public void drawSquares(int n, int d)
        {
            Canvas myCanvas = new Canvas();
            myCanvas.Width = 600;
            myCanvas.Height = 600;

            

            for (int i = n; i > 0; i--)
            {
                Rectangle rect = new Rectangle();
                rect.Fill = Brushes.Blue;
                rect.Width = 500 - (i * d);
                rect.Height = 200 - (i * d);

                if (rect.Fill == Brushes.Blue)
                    rect.Fill = Brushes.Cornsilk;
                else
                    rect.Fill = Brushes.Blue;

                myCanvas.Children.Add(rect);
            }

            this.Content = myCanvas;
        }
            
    }
}
