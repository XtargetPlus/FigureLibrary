using FigureLibrary.Figures.Concrete;
using Xunit;

namespace FigureLibrary.Tests;

public class FigureTest
{
    [Fact]
    public void FigureTestCircle()
    {
        // Arrange
        var figure = Figure.GetFigure<Circle>();

        // Act
        figure!.SetRadius(23);
        var result = figure.CalculateArea();

        // Fact
        Assert.Equal(1661.902697, result);
    }

    [Fact]
    public void FigureTestSquare()
    {
        // Arrange
        var figure = Figure.GetFigure<Square>();

        // Act
        figure!.SetSideLength(23);
        var result = figure.CalculateArea();

        // Fact
        Assert.Equal(529, result);
    }

    [Fact]
    public void FigureTestTriangle()
    {
        // Arrange
        var figure = Figure.GetFigure<Triangle>();

        // Act
        figure!.SetSides(23, 14, 11);
        var result = figure.CalculateArea();

        // Fact
        Assert.Equal(55.85696, result);
    }
}