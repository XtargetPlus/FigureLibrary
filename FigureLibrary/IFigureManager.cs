namespace FigureLibrary;

public interface IFigureManager
{
    void CalculateArea<TRequest, TResponse>(TRequest variables, out TResponse area) 
        where TRequest : class
        where TResponse : unmanaged;
}