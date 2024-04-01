using FigureLibrary.Figures.Squares;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.SquareTests;

public class DoubleSquareShould
{
    private readonly Square _sut = new();

    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { new DoubleSquareAriaVariables(23d), 529d };
        yield return new object[] { new DoubleSquareAriaVariables(66d), 4356d };
    }

    public static IEnumerable<object[]> GetInvalidInfo()
    {
        yield return new object[] { new DoubleSquareAriaVariables(-23d) };
        yield return new object[] { new DoubleSquareAriaVariables(0) };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenDoubleSideIsValid(DoubleSquareAriaVariables variables, double expected)
    {
        var actual = _sut.CalculateArea(variables);

        actual.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetInvalidInfo))]
    public void ReturnException_WhenDoubleSideIsInvalid(DoubleSquareAriaVariables variables)
    {
        _sut.Invoking(s => s.CalculateArea(variables)).Should().Throw<ArgumentException>();
    }
}