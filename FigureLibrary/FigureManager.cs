namespace FigureLibrary;

internal class FigureManager : IFigureManager
{
    private readonly IEnumerable<IFigureSelector> _selectors;

    public FigureManager(IEnumerable<IFigureSelector> selectors)
    {
        _selectors = selectors;
    }

    public void CalculateArea<TRequest, TResponse>(TRequest variables, out TResponse area) 
        where TRequest : class
        where TResponse : unmanaged 
    {
        var figureSelector = _selectors.OfType<IFigureSelector<TRequest, TResponse>>().FirstOrDefault();

        area = figureSelector?.CalculateArea(variables) ?? default;
    }
}