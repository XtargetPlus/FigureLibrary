using FigureLibrary.Figures.Circles;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.CircleTests;

public class DoubleCircleShould
{
    private readonly Circle _sut = new();

    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { new DoubleCircleAriaVariables(23d), 1661.902514d };
        yield return new object[] { new DoubleCircleAriaVariables(15d), 706.858347d };
    }

    public static IEnumerable<object[]> GetInvalidInfo()
    {
        yield return new object[] { new DoubleCircleAriaVariables(-23d) };
        yield return new object[] { new DoubleCircleAriaVariables(0) };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenDoubleRadiusIsValid(DoubleCircleAriaVariables variables, double expected)
    {
        var actual = _sut.CalculateArea(variables);
        actual.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetInvalidInfo))]
    public void ReturnException_WhenDoubleRadiusIsInvalid(DoubleCircleAriaVariables variables)
    {
        _sut.Invoking(s => s.CalculateArea(variables)).Should().Throw<ArgumentException>();
    }
}