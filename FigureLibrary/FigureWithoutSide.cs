using FigureLibrary.Figures.Concrete;

namespace FigureLibrary;

/// <summary>
/// Class for interacting with figures without sides    
/// </summary>
public class FigureWithoutSide
{
    /// <summary>
    /// Figure type without sides
    /// </summary>
    private readonly FigureWithoutSideType _figureType;

    /// <summary>
    /// Creating a class to interact with figures without sides
    /// </summary>
    /// <param name="figureType">Figure type with a side</param>
    public FigureWithoutSide(FigureWithoutSideType figureType)
    {
        _figureType = figureType;
    }

    /// <summary>
    /// Calculating the area of a figure
    /// </summary>
    /// <param name="radius">Figure radius</param>
    /// <returns>Figure area</returns>
    /// <exception cref="ArgumentOutOfRangeException">If an invalid figure type is passed, an error is raised</exception>
    public double CalculateArea(double radius)
    {
        switch (_figureType)
        {
            case FigureWithoutSideType.Circle:
                var figure = new Circle();
                figure.SetRadius(radius);
                return figure.CalculateArea();

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}