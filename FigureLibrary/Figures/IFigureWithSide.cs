namespace FigureLibrary.Figures;

/// <summary>
/// Interface for describing figures with a side
/// </summary>
public interface IFigureWithSide : IBaseFigureOperations
{
    /// <summary>
    /// Set sides to figure
    /// </summary>
    /// <param name="sides">Figure sides</param>
    void SetSides(double[] sides);
}