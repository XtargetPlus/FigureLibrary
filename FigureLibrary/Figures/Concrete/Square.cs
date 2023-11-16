namespace FigureLibrary.Figures.Concrete;

/// <summary>
/// Square
/// </summary>
public class Square : IFigureWithSide, IBaseFigureOperations
{
    /// <summary>
    /// One side of the square
    /// </summary>
    private double _sideLength;

    /// <summary>
    /// Specify the side of the square
    /// </summary>
    /// <param name="sides">The sides of the square, in this case 1 side is needed</param>>
    public void SetSides(double[] sides)
    {
        if (sides.Length is > 1 or 0)
            throw new ArgumentException("For a square, only 1 side needs to be specified");

        _sideLength = sides[0];
    }

    /// <summary>
    /// Calculate the area of the square
    /// </summary>
    /// <returns>Area of the square rounded to 6 decimal places</returns>
    public double CalculateArea() => Math.Round(Math.Pow(_sideLength, 2), 6);
}