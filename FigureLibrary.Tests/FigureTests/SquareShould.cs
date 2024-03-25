using FigureLibrary.Figures.Concrete;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureTests;

public class SquareShould
{
    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { new[] { 23d }, 529d };
        yield return new object[] { new[] { 66d }, 4356d };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenSideIsValid(double[] sides, double expected)
    {
        var figure = Figure.GetFigure<Square>();

        figure!.SetSides(sides);
        var actual = figure.CalculateArea();

        actual.Should().Be(expected);
    }

    [Fact]
    public void ReturnException_WhenSidesIsInvalid()
    {
        var figure = Figure.GetFigure<Square>();

        figure.Invoking(f => f!.SetSides(new double[] {})).Should().Throw<ArgumentException>();
    }
}