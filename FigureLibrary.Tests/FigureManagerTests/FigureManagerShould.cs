using FigureLibrary.Figures.Circles;
using FigureLibrary.Figures.Squares;
using FigureLibrary.Figures.Triangles;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureManagerTests;

public class FigureManagerShould
{
    [Fact]
    public void ReturnResult_WhenFigureIsExists()
    {
        var sut = new FigureManager(new IFigureSelector[]
        {
            new Circle(),
            new Triangle(),
            new Square(),
        });

        sut.CalculateArea(new DoubleCircleAriaVariables(23d), out double aria);
        aria.Should().Be(1661.902514d);
    }

    [Fact]
    public void ReturnResult_WhenFigureIsNoExists()
    {
        var sut = new FigureManager(new IFigureSelector[]
        {
            new Triangle(),
            new Square(),
        });

        sut.CalculateArea(new DoubleCircleAriaVariables(23d), out double aria);
        aria.Should().Be(default);
    }
}