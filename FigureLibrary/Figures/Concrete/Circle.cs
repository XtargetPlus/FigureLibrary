namespace FigureLibrary.Figures.Concrete;

/// <summary>
/// Circle
/// </summary>
public class Circle : IFigureWithoutSide
{
    /// <summary>
    /// Radius
    /// </summary>
    private double _radius;

    /// <summary>
    /// Set radius to circle
    /// </summary>
    /// <param name="radius">Circle radius</param>
    public void SetRadius(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Radius cannot be less than 0");
        _radius = radius;
    }

    /// <summary>
    /// Calculate the area of the сircle
    /// </summary>
    /// <returns>Area of the сircle rounded to 6 decimal places</returns>
    public double CalculateArea() => Math.Round(Math.Pow(_radius, 2) * Math.PI, 6);
}