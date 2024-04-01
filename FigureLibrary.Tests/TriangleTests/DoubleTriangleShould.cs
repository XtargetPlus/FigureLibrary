using FigureLibrary.Figures.Triangles;
using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.TriangleTests;

public class DoubleTriangleShould
{
    private readonly Triangle _sut = new();

    public static IEnumerable<object[]> GetValidInfo()
    {
        yield return new object[] { new DoubleTriangleAriaVariables(23d, 14d, 11d), 55.85696d };
        yield return new object[] { new DoubleTriangleAriaVariables(23d, 14d, 23d), 153.362316d };
        yield return new object[] { new DoubleTriangleAriaVariables(14d, 23d, 23d), 153.362316d };
        yield return new object[] { new DoubleTriangleAriaVariables(23d, 23d, 14d), 153.362316d };
        yield return new object[] { new DoubleTriangleAriaVariables(23d, 23d, 23d), 229.063719d };
    }

    public static IEnumerable<object[]> GetInvalidInfo()
    {
        yield return new object[] { new DoubleTriangleAriaVariables(0, 14d, 11d) };
        yield return new object[] { new DoubleTriangleAriaVariables(23d, 0, 23d) };
        yield return new object[] { new DoubleTriangleAriaVariables(14d, 23d, 0) };
        yield return new object[] { new DoubleTriangleAriaVariables(-1, 14d, 11d) };
        yield return new object[] { new DoubleTriangleAriaVariables(23d, -1, 23d) };
        yield return new object[] { new DoubleTriangleAriaVariables(14d, 23d, -1) };
        yield return new object[] { new DoubleTriangleAriaVariables(23d, 11d, 2d) };
        yield return new object[] { new DoubleTriangleAriaVariables(11d, 2d, 23d) };
        yield return new object[] { new DoubleTriangleAriaVariables(2d, 11d, 23d) };
    }

    [Theory]
    [MemberData(nameof(GetValidInfo))]
    public void ReturnResult_WhenDoubleSidesIsValid(DoubleTriangleAriaVariables variables, double expected)
    {
        var actual = _sut.CalculateArea(variables);

        actual.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetInvalidInfo))]
    public void ReturnException_WhenDoubleSidesIsInvalid(DoubleTriangleAriaVariables variables)
    {
        _sut.Invoking(s => s.CalculateArea(variables)).Should().Throw<ArgumentException>();
    }
}