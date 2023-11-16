using FigureLibrary.Figures;
using FigureLibrary.Figures.Concrete;

namespace FigureLibrary;

/// <summary>
/// Class for interacting with figures with sides   
/// </summary>
public class FigureWithSide
{
    /// <summary>
    /// figures without sides
    /// </summary>
    private readonly IFigureWithSide _figure;

    /// <summary>
    /// Creating a class to interact with figures with sides
    /// </summary>
    /// <param name="figureType">Figure type with sides</param>
    public FigureWithSide(FigureWithSideType figureType)
    {
        _figure = figureType switch
        {
            FigureWithSideType.Square => new Square(),
            FigureWithSideType.Triangle => new Triangle(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    /// <summary>
    /// Calculating the area of a figure
    /// </summary>
    /// <param name="sides">Figure sides</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException">If an invalid figure type is passed, an error is raised</exception>
    public double CalculateArea(double[] sides)
    {
        _figure.SetSides(sides);
        return _figure.CalculateArea();
    }
}