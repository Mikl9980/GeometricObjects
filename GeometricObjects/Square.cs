using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Square
    {
        public double X { get; }
        public double Y { get; }
        public double SideLength { get; }

        public Square(double x, double y, double sideLength)
        {
            X = x;
            Y = y;
            SideLength = sideLength;
        }

        public void Draw() => Console.WriteLine($"Square at ({X}, {Y}), Side Length = {SideLength}");
        public void Perimeter() => Console.WriteLine($"Square Perimeter = {4 * SideLength}");
        public void CalculateArea() => Console.WriteLine($"Square Area = {SideLength * SideLength}");
    }
}
