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
using System.Threading;

namespace WpfPaint2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double radius = 10;
        Color color = Colors.Red;
        int i = 10;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pos = e.GetPosition(_canvas);
            var ellipse = new Ellipse
            {
                Fill = new SolidColorBrush(color),
                Width = 2 * radius,
                Height = 2 * radius
            };
            Canvas.SetLeft(ellipse, pos.X - radius);
            Canvas.SetTop(ellipse, pos.Y - radius);
            _canvas.Children.Add(ellipse);

            var r = NewValue(color.R);
            var g = NewValue(color.G);
            var b = NewValue(color.B);
            color = Color.FromArgb(color.A, r, g, b);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _canvas.Children.Clear();
        }    
        private byte NewValue (byte value)
        {
            var dif = random.Next(-32, 32);
            var result = value + dif;
            if (result > 255)
                result = 255;
            if (result < 0)
                result = 0;
            return (byte)result;
        }
    }
}
