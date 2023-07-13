using Geometry.Abstractions;

namespace Geometry.Implemetations;

public class Triangle : ITriangle, IFigure
{
    private readonly double _edgeA;
    private readonly double _edgeB;
    private readonly double _edgeC;
    private readonly double[] edges;

    public bool IsTriangle => _edgeA < _edgeB + _edgeC && _edgeB < _edgeA + _edgeC && _edgeC < _edgeA + _edgeB;

    public Triangle(double a, double b, double c)
    {
        _edgeA = a;
        _edgeB = b;
        _edgeC = c;
        edges = new[] { a, b, c };
    }

    public double Square()
    {
        if (!IsTriangle)
        {
            throw new ArgumentException("Не является треугольником, т.к. одна из сторон больше суммы двух других.");
        }

        // Полупериметр
        var p = (_edgeA + _edgeB + _edgeC) / 2;
        // Формула Герона
        var value = p * (p - _edgeA) * (p - _edgeB) * (p - _edgeC);

        var square = Math.Sqrt(value);
        return square;
    }

    public bool RightTriangle()
    {
        // Теорема Пифагора
        var greaterEdge = edges.Max();
        var lessEdges = edges.Where(x => x < greaterEdge).ToArray();
        if (lessEdges.Length != 2)
        {
            return false;
        }

        return Math.Pow(greaterEdge, 2) == Math.Pow(lessEdges[0], 2) + Math.Pow(lessEdges[1], 2);
    }

}