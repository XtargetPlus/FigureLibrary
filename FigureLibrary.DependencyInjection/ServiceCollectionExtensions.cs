using FigureLibrary.Figures.Circles;
using FigureLibrary.Figures.Squares;
using FigureLibrary.Figures.Triangles;
using Microsoft.Extensions.DependencyInjection;

namespace FigureLibrary.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFigureLibrary(this IServiceCollection services) => services
        .AddScoped<IFigureManager, FigureManager>()
        .AddScoped<IFigureSelector, Circle>()
        .AddScoped<IFigureSelector, Square>()
        .AddScoped<IFigureSelector, Triangle>();
}