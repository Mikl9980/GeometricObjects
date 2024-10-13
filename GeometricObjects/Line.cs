using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects { 
public class Line
{
    public double X1 { get; }
    public double Y1 { get; }
    public double X2 { get; }
    public double Y2 { get; }

    public Line(double x1, double y1, double x2, double y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public void Draw() => Console.WriteLine($"Line from ({X1}, {Y1}) to ({X2}, {Y2})");
    public void Perimeter() => Console.WriteLine("Line Perimeter = 0");
    public void Area() => Console.WriteLine("Line Area = 0");
    public void CalculateArea() => Console.WriteLine("Line Area = 0");

    }
}

