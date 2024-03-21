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

namespace Malovani
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SolidColorBrush currentColor = Brushes.Black;

        public MainWindow()
        {
            InitializeComponent();
           
        }

       
        void DrawCircle(Point position)
        {
            Ellipse circle = new Ellipse();
            circle.Fill = currentColor;
            circle.Stroke = currentColor;
            circle.StrokeThickness = 1;
            circle.Width = 20;
            circle.Height = 20;

            Canvas.SetLeft(circle, position.X);
            Canvas.SetTop(circle, position.Y);   
            
            canvas.Children.Add(circle);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DrawCircle(e.GetPosition(canvas));
            }
            
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DrawCircle(e.GetPosition(canvas));
        }
    }
}
