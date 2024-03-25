using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureWithoutSideTests;

public class FigureWithoutSideShould
{
    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { 23d, 1661.902514d };
        yield return new object[] { 15d, 706.858347d };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenCircleRadiusIsValid(double radius, double expected)
    {
        var figure = new FigureWithoutSide(FigureWithoutSideType.Circle);

        var actual = figure.CalculateArea(radius);

        actual.Should().Be(expected);
    }

    [Fact]
    public void ReturnException_WhenFigureOutOfRange()
    {
        try
        {
            var figure = new FigureWithoutSide((FigureWithoutSideType)23);
        }
        catch (Exception exception)
        {
            exception.Should().BeAssignableTo<ArgumentOutOfRangeException>();
        }
    }
}