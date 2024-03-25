using FigureLibrary.Figures;
using FigureLibrary.Figures.Concrete;

namespace FigureLibrary;

/// <summary>
/// Class for interacting with figures without sides    
/// </summary>
public class FigureWithoutSide
{
    /// <summary>
    /// figures without sides
    /// </summary>
    private readonly IFigureWithoutSide _figure;

    /// <summary>
    /// Creating a class to interact with figures without sides
    /// </summary>
    /// <param name="figureType">Figure type with a side</param>
    public FigureWithoutSide(FigureWithoutSideType figureType)
    {
        _figure = figureType switch
        {
            FigureWithoutSideType.Circle => new Circle(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    /// <summary>
    /// Calculating the area of a figure
    /// </summary>
    /// <param name="radius">Figure radius</param>
    /// <returns>Figure area</returns>
    public double CalculateArea(double radius)
    {
        _figure.SetRadius(radius);
        return _figure.CalculateArea();
    }
}