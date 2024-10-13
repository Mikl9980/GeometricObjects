using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects { 

public class Rect
{
    public double X1 { get; }
    public double Y1 { get; }
    public double X2 { get; }
    public double Y2 { get; }

    public Rect(double x1, double y1, double x2, double y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public void Draw() => Console.WriteLine($"Rect at ({X1}, {Y1}), ({X2}, {Y2})");
    public void Perimeter() => Console.WriteLine($"Rect Perimeter = {2 * (Math.Abs(X2 - X1) + Math.Abs(Y2 - Y1))}");
    public void Area() => Console.WriteLine($"Rect Area = {Math.Abs(X2 - X1) * Math.Abs(Y2 - Y1)}");
    public void CalculateArea() => Console.WriteLine($"Rect Area = {Math.Abs(X2 - X1) * Math.Abs(Y2 - Y1)}");
    }
}
