using FigureLibrary.Figures.Squares;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.SquareTests;

public class IntSquareShould
{
    private readonly Square _sut = new();

    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { new IntSquareAriaVariables(23), 529 };
        yield return new object[] { new IntSquareAriaVariables(66), 4356 };
    }

    public static IEnumerable<object[]> GetInvalidInfo()
    {
        yield return new object[] { new IntSquareAriaVariables(-23) };
        yield return new object[] { new IntSquareAriaVariables(0) };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenDoubleSideIsValid(IntSquareAriaVariables variables, int expected)
    {
        var actual = _sut.CalculateArea(variables);

        actual.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetInvalidInfo))]
    public void ReturnException_WhenDoubleSideIsInvalid(IntSquareAriaVariables variables)
    {
        _sut.Invoking(s => s.CalculateArea(variables)).Should().Throw<ArgumentException>();
    }
}