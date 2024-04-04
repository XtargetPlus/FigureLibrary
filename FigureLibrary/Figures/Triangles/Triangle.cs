namespace FigureLibrary.Figures.Triangles;

/// <summary>
/// Triangle
/// </summary>
internal partial class Triangle : IFigureSelector<DoubleTriangleAriaVariables, double>
{
    /// <summary>
    /// Calculate double the area of the triangle
    /// </summary>
    /// <param name="variables">Triangle variables</param>
    /// <returns>Area of the triangle rounded to 6 decimal places</returns>
    public double CalculateArea(DoubleTriangleAriaVariables variables)
    {
        var (x, y, z) = variables;

        x = Math.Round(x, 6);
        y = Math.Round(y, 6);
        z = Math.Round(z, 6);

        if (x <= 0 || y <= 0 || z <= 0)
            throw new ArgumentException("The sides of a triangle cannot be equal or less than 0");
        if ((x + y).CompareTo(z) < 0 ||
            (x + z).CompareTo(y) < 0 ||
            (z + y).CompareTo(x) < 0)
            throw new ArgumentException("Such a triangle cannot exist");

        if ((x.CompareTo(y) == 0 && x.CompareTo(z) != 0) ||
            (x.CompareTo(z) == 0 && x.CompareTo(y) != 0) ||
            (y.CompareTo(z) == 0 && y.CompareTo(x) != 0))
        {
            return CalculateIsoscelesArea(x, y, z);
        }

        if (x.CompareTo(y) == 0 && x.CompareTo(z) == 0 && x.CompareTo(z) == 0)
        {
            return CalculateEquilateralArea(x);
        }
        return CalculateOrdinaryArea(x, y, z);
    }

    /// <summary>
    /// Calculate the area of the isosceles triangle
    /// </summary>
    /// <returns>Area of the isosceles triangle rounded to 6 decimal places</returns>
    private double CalculateIsoscelesArea(double x, double y, double z)
    {
        double equalSide;
        double bottomSide;
        if (x.CompareTo(y) == 0)
        {
            equalSide = x;
            bottomSide = z;
        }
        else if (x.CompareTo(z) == 0)
        {
            equalSide = x;
            bottomSide = y;
        }
        else
        {
            equalSide = y;
            bottomSide = x;
        }

        return Math.Round(bottomSide / 4 * Math.Sqrt(4 * Math.Pow(equalSide, 2) - Math.Pow(bottomSide, 2)), 6);
    }

    /// <summary>
    /// Calculate the area of the equilateral triangle
    /// </summary>
    /// <returns>Area of the equilateral triangle rounded to 6 decimal places</returns>
    private double CalculateEquilateralArea(double x) => Math.Round(Math.Sqrt(3) / 4 * Math.Pow(x, 2), 6);

    /// <summary>
    /// Calculate the area of the ordinary triangle
    /// </summary>
    /// <returns>Area of the ordinary triangle rounded to 6 decimal places</returns>
    private double CalculateOrdinaryArea(double x, double y, double z)
    {
        var p = (x + y + z) / 2;

        return Math.Round(Math.Sqrt(p * (p - x) * (p - y) * (p - z)), 6);
    }
}

/// <summary>
/// Triangle
/// </summary>
internal partial class Triangle : IFigureSelector<IntTriangleAriaVariables, int>
{
    /// <summary>
    /// Calculate int the area of the triangle
    /// </summary>
    /// <param name="variables">Triangle variables</param>
    /// <returns>Area of the triangle</returns>
    public int CalculateArea(IntTriangleAriaVariables variables)
    {
        var (x, y, z) = variables;

        if (x <= 0 || y <= 0 || z <= 0)
            throw new ArgumentException("The sides of a triangle cannot be equal or less than 0");
        if (x + y < z ||
            x + z < y ||
            z + y < x)
            throw new ArgumentException("Such a triangle cannot exist");

        if ((x == y && x != z) ||
            (x == z && x != y) ||
            (y == z && y != x))
        {
            return CalculateIsoscelesArea(x, y, z);
        }

        if (x == y && x == z && x == z)
        {
            return CalculateEquilateralArea(x);
        }
        return CalculateOrdinaryArea(x, y, z);
    }

    /// <summary>
    /// Calculate the area of the isosceles triangle
    /// </summary>
    /// <returns>Area of the isosceles triangle</returns>
    private int CalculateIsoscelesArea(int x, int y, int z)
    {
        int equalSide;
        int bottomSide;
        if (x == y)
        {
            equalSide = x;
            bottomSide = z;
        }
        else if (x == z)
        {
            equalSide = x;
            bottomSide = y;
        }
        else
        {
            equalSide = y;
            bottomSide = x;
        }

        return (int)((double)bottomSide / 4 * Math.Sqrt(4 * Math.Pow(equalSide, 2) - Math.Pow(bottomSide, 2)));
    }

    /// <summary>
    /// Calculate the area of the equilateral triangle
    /// </summary>
    /// <returns>Area of the equilateral triangle</returns>
    private int CalculateEquilateralArea(int x) => (int)(Math.Sqrt(3) / 4 * Math.Pow(x, 2));

    /// <summary>
    /// Calculate the area of the ordinary triangle
    /// </summary>
    /// <returns>Area of the ordinary triangle</returns>
    private int CalculateOrdinaryArea(int x, int y, int z)
    {
        var p = (x + y + z) / 2;

        return (int)Math.Sqrt(p * (p - x) * (p - y) * (p - z));
    }
}