namespace FigureLibrary.Figures;

/// <summary>
/// Interface for describing figures without a side
/// </summary>
public interface IFigureWithoutSide : IBaseFigureOperations
{
    /// <summary>
    /// Set radius to figure
    /// </summary>
    /// <param name="radius">Figure radius</param>
    void SetRadius(double radius);
}