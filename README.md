# FigureLibrary

A library for interacting with figures.

The following figures are currently represented:
1) Circle
2) Square
3) Rectangle

It is recommended to use the static class Figure to obtain figures.

Example use case:

```c#
var figure = Figure.GetFigure<Circle>();

if (figure == null)
    return;

figure.SetRadius(23);
Console.WriteLine(figure.CalculateArea());
```
