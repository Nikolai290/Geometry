using Geometry.Abstractions;

namespace Geometry.Implemetations;

public static class FigureFabric
{
    public static IFigure CreateFigure(params double[] edges)
    {
        if (edges.Length == 1)
        {
            return CreateCircle(edges[0]);
        }

        if (edges.Length == 3)
        {
            return CreateTriangle(edges[0], edges[1], edges[2]);
        }

        throw new ArgumentException("Фигуры с таким количеством параметров не описано в программе.");
    }
    public static IFigure CreateCircle(double radius)
    {
        return new Circle(radius);
    }
    
    public static IFigure CreateTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, c);
    }
}