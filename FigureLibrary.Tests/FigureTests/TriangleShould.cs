using FigureLibrary.Figures.Concrete;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureTests;

public class TriangleShould
{
    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { new[] { 23d, 14d, 11d }, 55.85696d };
        yield return new object[] { new[] { 23d, 14d, 23d }, 153.362316d };
        yield return new object[] { new[] { 14d, 23d, 23d }, 153.362316d };
        yield return new object[] { new[] { 23d, 23d, 14d }, 153.362316d };
        yield return new object[] { new[] { 23d, 23d, 23d }, 229.063719d };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenRadiusIsValid(double[] sides, double expected)
    {
        var figure = Figure.GetFigure<Triangle>();

        figure!.SetSides(sides);
        var actual = figure.CalculateArea();

        actual.Should().Be(expected);
    }

    [Fact]
    public void ReturnException_WhenSidesIsEmpty()
    {
        var figure = Figure.GetFigure<Triangle>();

        figure.Invoking(f => f!.SetSides(new double[] {})).Should().Throw<ArgumentException>();
    }

    [Fact]
    public void ReturnException_WhenTriangleCannotExist()
    {
        var figure = Figure.GetFigure<Triangle>();

        figure!.SetSides(new double[] { 1, 2, 100 });
        figure.Invoking(f => f!.CalculateArea()).Should().Throw<ArgumentException>();
    }
}