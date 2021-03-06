using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steny
{
    public static class Calculator
    {
        public static double Area(List<Point> points)
        {
            double s = 0;
            if (points.Count >= 3)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    s += TrapeArea(points[i], points[i + 1]);
                }
                s += TrapeArea(points[points.Count - 1], points[0]);
            }
            return Math.Abs(s/2);
        }
        public static double TrapeArea(Point p1,Point p2)
        {            
            return (p2.X-p1.X)*(p2.Y + p1.Y);
        }
        public static double Perimeter(List<Point> points)
        {
            double perimeter = 0;
            if (points.Count >= 2)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    perimeter += Distans(points[i], points[i + 1]);
                }
                perimeter += Distans(points[points.Count - 1], points[0]);
            }          
            return perimeter;
        }

        public static double Perimeter(int height, List<Point> points)
        {
            return height * Perimeter(points);
        }
        public static double Distans(Point p1,Point p2)
        {
            double distans = Math.Sqrt( Math.Pow(p1.X-p2.X,2)+ Math.Pow(p1.Y-p2.Y,2));
            return distans;
        }
    }
}
