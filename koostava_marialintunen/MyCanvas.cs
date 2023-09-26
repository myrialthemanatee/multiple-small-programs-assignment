using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace koostava_marialintunen
{
    class MyCanvas : Canvas
    {

        double x = 100, y = 100;
        double x2 = 200, y2 = 100;
        double x3 = 300, y3 = 100;
        double x4 = 150, y4 = 150;
        double x5 = 250, y5 = 150;

        protected override void OnRender(DrawingContext dc)
        {
            //base.OnRender(dc); 
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Blue, 8), new System.Windows.Point(x, y), 50, 50);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 8), new System.Windows.Point(x2, y2), 50, 50);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Red, 8), new System.Windows.Point(x3, y3), 50, 50);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Yellow, 8), new System.Windows.Point(x4, y4), 50, 50);
            dc.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Green, 8), new System.Windows.Point(x5, y5), 50, 50);
        }

        public void SetXY(double uusi_x, double uusi_y)
        {
            x = uusi_x;
            y = uusi_y;
            InvalidateVisual();
        }
        public void SetXY2(double uusi_x2, double uusi_y2)
        {
            x2 = uusi_x2;
            y2 = uusi_y2;
            InvalidateVisual();
        }
        public void SetXY3(double uusi_x3, double uusi_y3)
        {
            x3 = uusi_x3;
            y3 = uusi_y3;
            InvalidateVisual();
        }
        public void SetXY4(double uusi_x4, double uusi_y4)
        {
            x4 = uusi_x4;
            y4 = uusi_y4;
            InvalidateVisual();
        }
        public void SetXY5(double uusi_x5, double uusi_y5)
        {
            x5 = uusi_x5;
            y5 = uusi_y5;
            InvalidateVisual();
        }
    }
}
