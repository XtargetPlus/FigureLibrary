namespace FigureLibrary.Figures.Squares;

/// <summary>
/// Square
/// </summary>
internal class Square : IFigureSelector<DoubleSquareAriaVariables, double>, IFigureSelector<IntSquareAriaVariables, int>
{
    /// <summary>
    /// Calculate the double area of the square
    /// </summary>
    /// <param name="variables">Square variables</param>
    /// <returns>Area of the square rounded to 6 decimal places</returns>
    public double CalculateArea(DoubleSquareAriaVariables variables)
    {
        if (variables.Side <= 0)
            throw new ArgumentException("Side cannot be equal or less than 0");

        return Math.Round(Math.Pow(variables.Side, 2), 6);
    }

    /// <summary>
    /// Calculate the int area of the square
    /// </summary>
    /// <param name="variables">Square variables</param>
    /// <returns>Area of the square</returns>
    public int CalculateArea(IntSquareAriaVariables variables)
    {
        if (variables.Side <= 0)
            throw new ArgumentException("Side cannot be equal or less than 0");

        return (int)Math.Pow(variables.Side, 2);
    }
}