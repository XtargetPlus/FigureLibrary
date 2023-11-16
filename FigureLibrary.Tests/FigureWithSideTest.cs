using FigureLibrary.Figures.Concrete;
using Xunit;

namespace FigureLibrary.Tests;

public class FigureWithSideTest
{
    [Fact]
    public void FigureTestSquare()
    {
        // Arrange
        var figure = new FigureWithSide(FigureWithSideType.Square);
        double[] arr = { 23 };

        // Act
        var result = figure.CalculateArea(arr);

        // Fact
        Assert.Equal(529, result);
    }

    [Fact]
    public void FigureTestTriangle()
    {
        // Arrange
        var figure = new FigureWithSide(FigureWithSideType.Triangle);
        double[] arr = { 23, 14, 11 };

        // Act
        var result = figure.CalculateArea(arr);

        // Fact
        Assert.Equal(55.85696, result);
    }

    [Fact]
    public void FigureTestIsoscelesTriangle()
    {
        // Arrange
        var figure = new FigureWithSide(FigureWithSideType.Triangle);
        double[] arr = { 23, 14, 23 };

        // Act
        var result = figure.CalculateArea(arr);

        // Fact
        Assert.Equal(153.362316, result);
    }

    [Fact]
    public void FigureTestEquilateralTriangle()
    {
        // Arrange
        var figure = new FigureWithSide(FigureWithSideType.Triangle);
        double[] arr = { 23, 23, 23 };

        // Act
        var result = figure.CalculateArea(arr);

        // Fact
        Assert.Equal(229.063719, result);
    }
}