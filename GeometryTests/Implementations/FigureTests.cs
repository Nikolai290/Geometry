using FluentAssertions;
using Geometry.Implemetations;

namespace GeometryTests.Implementations;

public class FigureTests
{
    [Theory]
    [InlineData(Math.PI, 1d)]
    [InlineData(6d, 3d,4d,5d)]
    public void AllFiguresWithFabricTests(double expected, params double[] edges)
    {
        var figure = FigureFabric.CreateFigure(edges);
        var act = figure.Square();
        act.Should().Be(expected);
    }
    
    [Fact]
    public void Circle_Test()
    {
        var expected = Math.PI*4;
        var circle = new Circle(2);
        var act = circle.Square();
        act.Should().Be(expected);
    }
    
    [Fact]
    public void Triangle_Test()
    {
        var expected = 6;
        var triangle = new Triangle(3,4,5);
        var act = triangle.Square();
        act.Should().Be(expected);
    }
        
    [Fact]
    public void Triangle_IsRigth_Test()
    {
        var triangle = new Triangle(3,4,5);
        triangle.RightTriangle().Should().BeTrue();
    }
            
    [Fact]
    public void Triangle_IsNotRigth_Test()
    {
        var triangle = new Triangle(4,4,5);
        triangle.RightTriangle().Should().BeFalse();
    }
    
    [Fact]
    public void Triangle_IsNotRigth2_Test()
    {
        var triangle = new Triangle(4,5,5);
        triangle.RightTriangle().Should().BeFalse();
    }
    
    [Fact]
    public void TriangleSquareTest_ThrownArgumentException()
    {
        double a = 3, b = 4, c = 8;
        var act = () => FigureFabric.CreateTriangle(a,b,c).Square();
        act.Should().Throw<ArgumentException>();
    }

}