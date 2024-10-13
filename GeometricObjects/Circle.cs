using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle
    {
        public double X { get; }
        public double Y { get; }
        public double Radius { get; }

        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Draw() => Console.WriteLine($"Circle at ({X}, {Y}), Radius = {Radius}");
        public void Perimeter() => Console.WriteLine($"Circle Perimeter = {2 * Math.PI * Radius}");
        public void Area() => Console.WriteLine($"Circle Area = {Math.PI * Radius * Radius}");
        public void CalculateArea() => Console.WriteLine($"Circle Area = {Math.PI * Radius * Radius}");
    }
}
