using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureWithSideTests;

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
        var figure = new FigureWithSide(FigureWithSideType.Triangle);

        var actual = figure.CalculateArea(sides);

        actual.Should().Be(expected);
    }

    [Fact]
    public void ReturnException_WhenSidesIsEmpty()
    {
        var figure = new FigureWithSide(FigureWithSideType.Triangle);

        figure.Invoking(f => f.CalculateArea(new double[] {})).Should().Throw<ArgumentException>();
    }
}