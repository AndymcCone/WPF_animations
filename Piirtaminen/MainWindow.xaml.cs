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
using System.Windows.Media.Animation;

namespace Piirtaminen
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyCanvas.SetCoordinates();
            MyCanvas.InvalidateVisual();

            Random rnd = new Random();

            DoubleAnimation a = new DoubleAnimation();
            a.From = Canvas.GetTop(musta);
            a.To = rnd.Next(0, 320);
            a.Duration = new Duration(TimeSpan.Parse("0:0:0.2"));
            musta.BeginAnimation(Canvas.TopProperty, a);

            DoubleAnimation b = new DoubleAnimation();
            b.From = Canvas.GetTop(sininen);
            b.To = rnd.Next(0, 320);
            b.Duration = new Duration(TimeSpan.Parse("0:0:0.3"));
            sininen.BeginAnimation(Canvas.TopProperty, b);

            DoubleAnimation c = new DoubleAnimation();
            c.From = Canvas.GetLeft(sininen);
            c.To = rnd.Next(0, 320);
            c.Duration = new Duration(TimeSpan.Parse("0:0:0.3"));
            sininen.BeginAnimation(Canvas.LeftProperty, c);

            DoubleAnimation d = new DoubleAnimation();
            d.From = Canvas.GetTop(oranssi);
            d.To = rnd.Next(0, 320);
            d.Duration = new Duration(TimeSpan.Parse("0:0:0.4"));
            oranssi.BeginAnimation(Canvas.TopProperty, d);

            DoubleAnimation f = new DoubleAnimation();
            f.From = Canvas.GetLeft(oranssi);
            f.To = rnd.Next(0, 320);
            f.Duration = new Duration(TimeSpan.Parse("0:0:0.4"));
            oranssi.BeginAnimation(Canvas.LeftProperty, f);

            DoubleAnimation g = new DoubleAnimation();
            g.From = Canvas.GetTop(vihrea);
            g.To = rnd.Next(0, 320);
            g.Duration = new Duration(TimeSpan.Parse("0:0:0.5"));
            vihrea.BeginAnimation(Canvas.TopProperty, g);

            DoubleAnimation h = new DoubleAnimation();
            h.From = Canvas.GetLeft(vihrea);
            h.To = rnd.Next(0, 320);
            h.Duration = new Duration(TimeSpan.Parse("0:0:0.5"));
            vihrea.BeginAnimation(Canvas.LeftProperty, h);

            DoubleAnimation i = new DoubleAnimation();
            i.From = Canvas.GetTop(punainen);
            i.To = rnd.Next(0, 320);
            i.Duration = new Duration(TimeSpan.Parse("0:0:0.6"));
            punainen.BeginAnimation(Canvas.TopProperty, i);

            DoubleAnimation j = new DoubleAnimation();
            j.From = Canvas.GetLeft(punainen);
            j.To = rnd.Next(0, 320);
            j.Duration = new Duration(TimeSpan.Parse("0:0:0.6"));
            punainen.BeginAnimation(Canvas.LeftProperty, j);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
