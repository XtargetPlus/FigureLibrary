# FigureLibrary

A library for interacting with figures.

The following figures are currently represented:
1) Circle
2) Square
3) Rectangle

You can use the static class Figure to obtain figures.

Example use case:

```c#
var figure = Figure.GetFigure<Circle>();

if (figure == null)
    return;

figure.SetRadius(23);
Console.WriteLine(figure.CalculateArea());
```
The function for entering sides is different for each figure. 

To add a new figure, you need to create a class at the path FigureLibrary/Figures/Concrete and implement the IBaseFigureOperations interface. Next, add a new "if" to Figure.GetFigure<TOut>:

```c#
if (typeof(TOut) == typeof(YOURFIGURECLASS))
    return new TOut();
```

Another way to interact with figures, through a small proxy in the form of the FigureWithSide and FigureWithoutSide classes.

```c#
var figure = new FigureWithSide(FigureWithSideType.Square);

double[] sides = { 23 }; 
var area = figure.CalculateArea(sides);
```
```c#
var figure = new FigureWithoutSide(FigureWithoutSideType.Circle);

double radius = 23;
var area = figure.CalculateArea(radius);
```

In this case, to add a new figure, you need to inherit from the interface IFigureWithoutSide or IBaseFigureOperations depending on what kind of figure. 

Then add the type to the appropriate enum, and add the string to the constructors of the FigureWithSide or FigureWithoutSide class.

```c#
public FigureWithSide(FigureWithSideType figureType)
{
    _figure = figureType switch
    {
        FigureWithSideType.Square => new Square(),
        FigureWithSideType.Triangle => new Triangle(),
        FigureWithSideType.YOURFIGURE => new YOURFIGURE(),
        _ => throw new ArgumentOutOfRangeException()
    };
}
```
