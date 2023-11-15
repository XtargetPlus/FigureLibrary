using FigureLibrary.Figures.Concrete;

namespace FigureLibrary;

/// <summary>
/// Static class for generalized interaction with figures
/// </summary>
public static class Figure
{
    /// <summary>
    /// Getting the figure specified in TOut
    /// </summary>
    /// <typeparam name="TOut">Class of the figure we want to get</typeparam>
    /// <returns>Empty figure object or null if no such figure exists</returns>
    public static TOut? GetFigure<TOut>()
        where TOut : class, new()  
    {
        if (typeof(TOut) == typeof(Circle)) 
            return new TOut();
        if (typeof(TOut) == typeof(Square))
            return new TOut();
        if (typeof(TOut) == typeof(Triangle))
            return new TOut();

        return null;
    }
}