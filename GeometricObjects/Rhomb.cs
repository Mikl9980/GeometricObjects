using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Rhomb
    {
        public double X { get; }
        public double Y { get; }
        public double Height { get; }
        public double Width { get; }

        public Rhomb(double x, double y, double height, double width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public void Draw() => Console.WriteLine($"Rhomb at ({X}, {Y}), Height = {Height}, Width = {Width}");
        public void Perimeter() => Console.WriteLine($"Rhomb Perimeter = {4 * Math.Sqrt(Math.Pow(Height / 2, 2) + Math.Pow(Width / 2, 2))}");
        public void Area() => Console.WriteLine($"Rhomb Area = {Height * Width / 2}");
        public void CalculateArea() => Console.WriteLine($"Rhomb Area = {Height * Width / 2}");
    }
}
