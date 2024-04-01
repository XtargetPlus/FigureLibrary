using FigureLibrary.Figures.Triangles;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.TriangleTests;

public class IntTriangleShould
{
    private readonly Triangle _sut = new();

    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { new IntTriangleAriaVariables(23, 14, 11), 55 };
        yield return new object[] { new IntTriangleAriaVariables(23, 14, 23), 153 };
        yield return new object[] { new IntTriangleAriaVariables(14, 23, 23), 153 };
        yield return new object[] { new IntTriangleAriaVariables(23, 23, 14), 153 };
        yield return new object[] { new IntTriangleAriaVariables(23, 23, 23), 229 };
    }

    public static IEnumerable<object[]> GetInvalidInfo()
    {
        yield return new object[] { new IntTriangleAriaVariables(0, 14, 11) };
        yield return new object[] { new IntTriangleAriaVariables(23, 0, 23) };
        yield return new object[] { new IntTriangleAriaVariables(14, 23, 0) };
        yield return new object[] { new IntTriangleAriaVariables(-1, 14, 11) };
        yield return new object[] { new IntTriangleAriaVariables(23, -1, 23) };
        yield return new object[] { new IntTriangleAriaVariables(14, 23, -1) };
        yield return new object[] { new IntTriangleAriaVariables(23, 11, 2) };
        yield return new object[] { new IntTriangleAriaVariables(11, 2, 23) };
        yield return new object[] { new IntTriangleAriaVariables(2, 11, 23) };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenIntSidesIsValid(IntTriangleAriaVariables variables, int expected)
    {
        var actual = _sut.CalculateArea(variables);

        actual.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetInvalidInfo))]
    public void ReturnException_WhenIntSidesIsInvalid(IntTriangleAriaVariables variables)
    {
        _sut.Invoking(s => s.CalculateArea(variables)).Should().Throw<ArgumentException>();
    }
}