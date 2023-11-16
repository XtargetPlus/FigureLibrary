namespace FigureLibrary.Figures;

/// <summary>
/// Interface that specifies the basic functionality of the figures 
/// </summary>
public interface IBaseFigureOperations
{
    /// <summary>
    /// Calculate the area of the figure
    /// </summary>
    /// <returns>Area of the figure rounded to 6 decimal places</returns>
    double CalculateArea();
}