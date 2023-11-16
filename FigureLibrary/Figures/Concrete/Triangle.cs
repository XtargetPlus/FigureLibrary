namespace FigureLibrary.Figures.Concrete;

/// <summary>
/// Triangle
/// </summary>
public class Triangle : IBaseFigureOperations
{
    private double _x;
    private double _y;
    private double _z;

    /// <summary>
    /// Specify the sides of the triangle
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    public void SetSides(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    /// <summary>
    /// Calculate the area of the triangle
    /// </summary>
    /// <returns>Area of the triangle rounded to 6 decimal places</returns>
    public double CalculateArea()
    {
        if ((_x + _y).CompareTo(_z) < 0 || (_x + _z).CompareTo(_y) < 0 || (_z + _y).CompareTo(_x) < 0)
            throw new ArgumentException("Such a triangle cannot exist");

        if (_x.CompareTo(_y) == 0 || _x.CompareTo(_z) == 0 || _y.CompareTo(_z) == 0)
            return CalculateIsoscelesArea();
        if (_x.CompareTo(_y) == 0 && _x.CompareTo(_z) == 0 && _y.CompareTo(_z) == 0)
            return CalculateEquilateralArea();
        return CalculateOrdinaryArea();
    }

    /// <summary>
    /// Calculate the area of the isosceles triangle
    /// </summary>
    /// <returns>Area of the isosceles triangle rounded to 6 decimal places</returns>
    private double CalculateIsoscelesArea()
    {
        double equalSide;
        double bottomSide;
        if (_x.CompareTo(_y) == 0)
        {
            equalSide = _x;
            bottomSide = _z;
        }
        else if (_x.CompareTo(_z) == 0)
        {
            equalSide = _x;
            bottomSide = _y;
        }
        else
        {
            equalSide = _y;
            bottomSide = _x;
        }

        return Math.Round(bottomSide / 4 * Math.Sqrt(4 * Math.Pow(equalSide, 2) - Math.Pow(bottomSide, 2)), 6);
    }

    /// <summary>
    /// Calculate the area of the equilateral triangle
    /// </summary>
    /// <returns>Area of the equilateral triangle rounded to 6 decimal places</returns>
    private double CalculateEquilateralArea() => Math.Round(Math.Sqrt(3) / 4 * Math.Pow(_x, 2), 6);

    /// <summary>
    /// Calculate the area of the ordinary triangle
    /// </summary>
    /// <returns>Area of the ordinary triangle rounded to 6 decimal places</returns>
    private double CalculateOrdinaryArea()
    {
        var p = Math.Round((_x + _y + _z) / 2, 6);

        return Math.Round(Math.Sqrt(p * (p - _x) * (p - _y) * (p - _z)), 6);
    }
}