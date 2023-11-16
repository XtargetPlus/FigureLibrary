using FigureLibrary.Figures.Concrete;
using Xunit;

namespace FigureLibrary.Tests;

public class FigureWithoutSideTest
{
    [Fact]
    public void FigureTestCircle()
    {
        // Arrange
        var figure = new FigureWithoutSide(FigureWithoutSideType.Circle);

        // Act
        var result = figure.CalculateArea(23);

        // Fact
        Assert.Equal(1661.902697, result);
    }
}