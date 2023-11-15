namespace FigureLibrary.Figures.Concrete;

/// <summary>
/// Square
/// </summary>
public class Square : IBaseFigureOperations
{
    /// <summary>
    /// 
    /// </summary>
    private double _sideLength;

    /// <summary>
    /// Specify the side of the square
    /// </summary>
    /// <param name="sideLength"></param>
    public void SetSideLength(double sideLength) => _sideLength = sideLength;

    /// <summary>
    /// Calculate the area of the square
    /// </summary>
    /// <returns>Area of the square rounded to 6 decimal places</returns>
    public double CalculateArea() => Math.Round(Math.Pow(_sideLength, 2), 6);
}