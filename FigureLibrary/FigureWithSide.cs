using FigureLibrary.Figures.Concrete;

namespace FigureLibrary;

/// <summary>
/// Class for interacting with figures with sides   
/// </summary>
public class FigureWithSide
{
    /// <summary>
    /// Figure type with sides
    /// </summary>
    private readonly FigureWithSideType _figureType;

    /// <summary>
    /// Creating a class to interact with figures with sides
    /// </summary>
    /// <param name="figureType">Figure type with sides</param>
    public FigureWithSide(FigureWithSideType figureType)
    {
        _figureType = figureType;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sides"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException">If an invalid figure type is passed, an error is raised</exception>
    public double CalculateArea(double[] sides)
    {
        switch (_figureType)
        {
            case FigureWithSideType.Square:
                var figure = new Square();
                figure.SetSides(sides);
                return figure.CalculateArea();
            case FigureWithSideType.Triangle:
                var triangle = new Triangle();
                triangle.SetSides(sides);
                return triangle.CalculateArea();

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}