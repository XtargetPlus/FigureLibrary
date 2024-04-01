namespace FigureLibrary.Figures.Circles;

/// <summary>
/// Circle
/// </summary>
internal class Circle : IFigureSelector<DoubleCircleAriaVariables, double>, IFigureSelector<IntCircleAriaVariables, int>
{
    /// <summary>
    /// Calculate the double area of the сircle
    /// </summary>
    /// <param name="variables">Circle variables</param>
    /// <returns>Area of the сircle rounded to 6 decimal places</returns>
    public double CalculateArea(DoubleCircleAriaVariables variables)
    {
        if (variables.Radius <= 0)
            throw new ArgumentException("Radius cannot be equal or less than 0");

        return Math.Round(Math.Pow(variables.Radius, 2) * Math.PI, 6);
    }

    /// <summary>
    /// Calculate the int area of the сircle
    /// </summary>
    /// <param name="variables">Circle variables</param>
    /// <returns>Area of the сircle</returns>
    public int CalculateArea(IntCircleAriaVariables variables)
    {
        if (variables.Radius <= 0)
            throw new ArgumentException("Radius cannot be equal or less than 0");

        return (int)(Math.Pow(variables.Radius, 2) * Math.PI);
    }
}