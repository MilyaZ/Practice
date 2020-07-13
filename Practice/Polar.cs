using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Polar
    {
        double polar_radius;
        double polar_angle;
        double Polar_Radius{ get { return polar_radius; } set { polar_radius = value; } }
        double Polar_Ahgle { get { return polar_angle; } set { polar_angle = value; } }
       public double GetX() { return Polar_Radius * Math.Cos(polar_angle); }
        public double GetY() { return Polar_Radius * Math.Sin(polar_angle); }
        public Polar()
        {
            polar_angle = 0;
            polar_radius = 1;
        }
        public Polar(decimal radius, decimal angle)
        {
            polar_radius = Convert.ToDouble(radius);
            polar_angle = Convert.ToDouble(angle) * Math.PI;
        }
        double point(Polar p)
        {
            return Math.Sqrt(polar_radius * polar_radius + p.Polar_Radius * p.Polar_Radius - 2 * polar_radius * p.Polar_Radius * Math.Cos(polar_angle - p.Polar_Ahgle));
        }
        double dist(Polar f, Polar s)
        {
            var y0 = GetY();
            var x0 = GetX();
            var y1 = f.GetY();
            var x1 = f.GetX();
            var x2 = f.GetX();
            var y2 = s.GetY();

            return Math.Abs((y2 - y1) * x0 - (x2 - x1) * y0 + x2 * y1 - y2 * x1) / Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));
        }
       public double area_triangle(Polar f, Polar s)
        {
            var height = dist(f, s);
            var side = f.point(s);
            return height*side/2;
        }
    }
}
