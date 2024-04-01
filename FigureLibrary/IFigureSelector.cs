namespace FigureLibrary;

public interface IFigureSelector
{
}

public interface IFigureSelector<in TRequest, out TResponse> : IFigureSelector
    where TRequest : class
    where TResponse : unmanaged
{
    public TResponse CalculateArea(TRequest variables);
}