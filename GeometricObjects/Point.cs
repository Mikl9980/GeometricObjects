using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Draw() => Console.WriteLine($"Point at ({X}, {Y}), Perimeter = 0, Area = 0");
        public void Perimeter() => Console.WriteLine("Point Perimeter = 0");
        public void Area() => Console.WriteLine("Point Area = 0");

        public void CalculateArea() => Console.WriteLine("Point Area = 0");
    }
}
