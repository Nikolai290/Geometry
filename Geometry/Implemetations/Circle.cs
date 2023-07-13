using Geometry.Abstractions;

namespace Geometry.Implemetations;

public class Circle : IFigure
{
    private double _radius { get; }

    public Circle(double radius)
    {
        _radius = radius;
    }
    
    public double Square()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}