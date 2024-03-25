namespace FigureLibrary.Figures.Concrete;

/// <summary>
/// Triangle
/// </summary>
public class Triangle : IFigureWithSide
{
    private double _x;
    private double _y;
    private double _z;

    /// <summary>
    /// Specify the sides of the triangle
    /// </summary>
    /// <param name="sides">Triangle sides</param>>
    public void SetSides(double[] sides)
    {
        if (sides.Length is > 3 or < 3)
            throw new ArgumentException("For a triangle, only 3 side needs to be specified");

        _x = Math.Round(sides[0], 6);
        _y = Math.Round(sides[1], 6);
        _z = Math.Round(sides[2], 6);
    }

    /// <summary>
    /// Calculate the area of the triangle
    /// </summary>
    /// <returns>Area of the triangle rounded to 6 decimal places</returns>
    public double CalculateArea()
    {
        if ((_x + _y).CompareTo(_z) < 0 || (_x + _z).CompareTo(_y) < 0 || (_z + _y).CompareTo(_x) < 0)
            throw new ArgumentException("Such a triangle cannot exist");

        if (_x.CompareTo(_y) == 0 && _x.CompareTo(_z) != 0
            || _x.CompareTo(_z) == 0 && _x.CompareTo(_y) != 0
            || _y.CompareTo(_z) == 0 && _y.CompareTo(_x) != 0)
        {
            return CalculateIsoscelesArea();
        }

        if (_x.CompareTo(_y) == 0 && _x.CompareTo(_z) == 0 && _y.CompareTo(_z) == 0)
        {
            return CalculateEquilateralArea();
        }
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
        var p = (_x + _y + _z) / 2;

        return Math.Round(Math.Sqrt(p * (p - _x) * (p - _y) * (p - _z)), 6);
    }
}