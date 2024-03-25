using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureTests;

public class FigureShould
{
    [Fact]
    public void ReturnNull_WhenFigureDoesnotExits()
    {
        Figure.GetFigure<List<int>>().Should().BeNull();
    }
}