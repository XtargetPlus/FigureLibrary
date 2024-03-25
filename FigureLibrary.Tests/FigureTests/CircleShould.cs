using FigureLibrary.Figures.Concrete;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureTests;

public class CircleShould
{
    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { 23d, 1661.902514d };
        yield return new object[] { 15d, 706.858347d };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenRadiusIsValid(double radius, double expected)
    {
        var figure = Figure.GetFigure<Circle>();

        figure!.SetRadius(radius);
        var actual = figure.CalculateArea();

        actual.Should().Be(expected);
    }

    [Fact]
    public void ReturnException_WhenRadiusIsInvalid()
    {
        var figure = Figure.GetFigure<Circle>();

        figure.Invoking(f => f!.SetRadius(-23)).Should().Throw<ArgumentException>();
    }
}