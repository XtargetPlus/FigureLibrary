using FigureLibrary.Figures.Circles;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.CircleTests;

public class IntCircleShould
{
    private readonly Circle _sut = new();

    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { new IntCircleAriaVariables(23), 1661 };
        yield return new object[] { new IntCircleAriaVariables(15), 706 };
    }

    public static IEnumerable<object[]> GetInvalidInfo()
    {
        yield return new object[] { new IntCircleAriaVariables(-23) };
        yield return new object[] { new IntCircleAriaVariables(0) };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenIntRadiusIsValid(IntCircleAriaVariables variables, int expected)
    {
        var actual = _sut.CalculateArea(variables);
        actual.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetInvalidInfo))]
    public void ReturnException_WhenintRadiusIsInvalid(IntCircleAriaVariables variables)
    {
        _sut.Invoking(s => s.CalculateArea(variables)).Should().Throw<ArgumentException>();
    }
}