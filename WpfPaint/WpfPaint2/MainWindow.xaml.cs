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

namespace WpfPaint2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double radius = 10;
        Color color = Colors.Red;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pos = e.GetPosition(_canvas);
            var ellipse = new Ellipse
            {
                Fill=new SolidColorBrush(color),
                Width=2*radius,
                Height=2*radius
            };
            Canvas.SetLeft(ellipse, pos.X - radius);
            Canvas.SetTop(ellipse, pos.Y - radius);
            _canvas.Children.Add(ellipse);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _canvas.Children.Clear();
        }

        private void RadiusTextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(_radiusText.Text, out var r))
                radius = r;
        }        
        private void RTextChanged(object sender, TextChangedEventArgs e)
        {
            if (byte.TryParse(_rText.Text, out var r))
                color = Color.FromArgb(color.A ,r, color.G, color.B);
        }        
        private void GTextChanged(object sender, TextChangedEventArgs e)
        {
            if (byte.TryParse(_gText.Text, out var g))
                color = Color.FromArgb(color.A, color.R, g, color.B);
        }        
        private void BTextChanged(object sender, TextChangedEventArgs e)
        {
            if (byte.TryParse(_bText.Text, out var b))
                color = Color.FromArgb(color.A, color.R, color.G, b);
        }
        private void ATextChanged(object sender, TextChangedEventArgs e)
        {
            if (byte.TryParse(_aText.Text, out var a))
                color = Color.FromArgb(a, color.R, color.G, color.B);
        }
    }
}
