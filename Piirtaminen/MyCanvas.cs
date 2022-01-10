using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Piirtaminen
{
    internal class MyCanvas : Canvas
    {
        double a = 110;
        double b = 200;
        double c = 155;
        double d = 240;
        double f = 200;
        double g = 200;
        double h = 245;
        double i = 240;
        double j = 290;
        double k = 200;
        


        protected override void OnRender(DrawingContext dc)
        {
            //base.OnRender(dc);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Blue, 6), new System.Windows.Point(a, b), 37, 37);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Orange, 6), new System.Windows.Point(c, d), 37, 37);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 6), new System.Windows.Point(f, g), 37,37);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Green, 6), new System.Windows.Point(h, i), 37, 37);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Red, 6), new System.Windows.Point(j, k), 37, 37);
                        
        }

        public void SetCoordinates()
        {
            Random rnd = new Random();
            var minx = 20;
            var maxx = 339;
            var miny = 37;
            var maxy = 370;

            this.a = rnd.Next(minx, maxx);
            this.b = rnd.Next(miny, maxy);
            this.c = rnd.Next(minx, maxx);
            this.d = rnd.Next(miny, maxy);
            this.f = rnd.Next(minx, maxx);
            this.g = rnd.Next(miny, maxy);
            this.h = rnd.Next(minx, maxx);
            this.i = rnd.Next(miny, maxy);
            this.j = rnd.Next(minx, maxx);
            this.k = rnd.Next(miny, maxy);




        }


    }
}
