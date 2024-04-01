# FigureLibrary

Библиотека для взаимодействия с фигурами.

Реализованы следующие фигуры:
1) Circle
2) Square
3) Rectangle

Прежде чем воспользоваться функционалом фигур, требуется подключить библиотеку к проекту. Далее следует добавить библиотеку в DI:

```c#
builder.Services.AddFigureLibrary();
```

После чего можно добавлять интерфейс `IFigureManager` в классы для дальнейшего использования.

Пример использования:

```c#
internal class GetForumsUseCase(IGetForumsStorage storage, IFigureManager figureManager)
    : IRequestHandler<GetForumsQuery, IEnumerable<ForumDto>>
{
    public Task<IEnumerable<ForumDto>> Handle(GetForumsQuery query, CancellationToken cancellationToken)
    {
        figureManager.CalculateArea(new DoubleTriangleAriaVariables(23d, 14d, 11d), out double area);
        Console.WriteLine($"Для чего-то посчитали площадь треугольника: {area}");

        return storage.GetForums(cancellationToken);
    }
}
```

Если класс TReuqest начинается с Double, значит TResponse ожидается double. Аналогично с типом int. 

Float и decimal не поддерживаются
