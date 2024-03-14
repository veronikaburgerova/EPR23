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
            
        }

        public void drawLinedSquare()
        {
            Canvas myCanvas = new Canvas();
            myCanvas.Width = 600;
            myCanvas.Height = 600;

            for (int i = 0; i < 4; i++)
            {
                Line line = drawLine();
                myCanvas.Children.Add(line);
            }
        }

        Line drawLine(int x1, int y1, int x2, int y2)
        {
            Line myLine = new Line();

            myLine.X1 = x1;
            myLine.Y1 = y1;
            myLine.X2 = x2;
            myLine.Y2 = y2;

            myLine.Stroke = Brushes.Purple;
            myLine.StrokeThickness = 10;

            return myLine;
        }


        //public void drawLine()
        //{
        //    Canvas myCanvas = new Canvas();
        //    myCanvas.Width = 600;
        //    myCanvas.Height = 600;

        //    Line myLine = new Line();

        //    myLine.X1 = 20;
        //    myLine.Y1 = 20;
        //    myLine.X2 = 300;
        //    myLine.Y2 = 20;

        //    myLine.Stroke = Brushes.Purple;
        //    myLine.StrokeThickness = 10;

        //    myCanvas.Children.Add(myLine);
        //    this.Content = myCanvas;
    }

        public void drawSquares(int n, int d)
        {
            Canvas myCanvas = new Canvas();
            myCanvas.Width = 600;
            myCanvas.Height = 600;
            Brush color = Brushes.Blue;

            for (int i = n; i > 0; i--)
            {

                Rectangle rect = new Rectangle();


                rect.Width = i * d;
                rect.Height = i * d;

                SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 238, 16, 32));
                if (color == Brushes.Blue)
                {
                    color = brush;
                } 
                else
                    color = Brushes.Blue;

                rect.Fill = color;
                myCanvas.Children.Add(rect);
            }

            this.Content = myCanvas;
        }

        
            
    }
}
