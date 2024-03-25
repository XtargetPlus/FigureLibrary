using FigureLibrary.Figures.Concrete;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureWithSideTests;

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
        var figure = new FigureWithSide(FigureWithSideType.Square);

        var actual = figure.CalculateArea(sides);

        actual.Should().Be(expected);
    }

    [Fact]
    public void ReturnException_WhenSidesIsInvalid()
    {
        var figure = new FigureWithSide(FigureWithSideType.Square);

        figure.Invoking(f => f.CalculateArea(new double[] {})).Should().Throw<ArgumentException>();
    }
}