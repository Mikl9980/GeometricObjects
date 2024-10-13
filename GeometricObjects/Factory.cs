using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public static class Factory
    {
        public static object Create(string type, params double[] parameters)
        {
            return type.ToLower() switch
            {
                "point" => new Point(parameters[0], parameters[1]),
                "rect" => new Rect(parameters[0], parameters[1], parameters[2], parameters[3]),
                "line" => new Line(parameters[0], parameters[1], parameters[2], parameters[3]),
                "circle" => new Circle(parameters[0], parameters[1], parameters[2]),
                "rhomb" => new Rhomb(parameters[0], parameters[1], parameters[2], parameters[3]),
                "square" => new Square(parameters[0], parameters[1], parameters[2]),
                _ => throw new ArgumentException($"Unknown type: {type}")
            };
        }
    }
}
