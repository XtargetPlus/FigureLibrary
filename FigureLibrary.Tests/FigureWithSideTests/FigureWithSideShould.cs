using FluentAssertions;
using Xunit;

namespace FigureLibrary.Tests.FigureWithSideTests;

public class FigureWithSideShould
{
    [Fact]
    public void ReturnException_WhenFigureOutOfRange()
    {
        try
        {
            var figure = new FigureWithSide((FigureWithSideType)23);
        }
        catch (Exception exception)
        {
            exception.Should().BeAssignableTo<ArgumentOutOfRangeException>();
        }
    }
}