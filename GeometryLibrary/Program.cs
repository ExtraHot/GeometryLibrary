using System;
using GeometryLibrary.Figures;

namespace GeometryLibrary;

class Program
{
    static void Main(string[] args)
    {
        double circleRadius = 5.0;
        var circle = new Circle(circleRadius);
        Console.WriteLine($"Площадь круга с радиусом {circleRadius} = {circle.CalculateArea()}");

        double a = 3.0,
            b = 4.0,
            c = 5.0;
        var triangle = new Triangle(a, b, c);
        Console.WriteLine(
            $"Площадь треугольника со сторонами {a}, {b}, {c} = {triangle.CalculateArea()}"
        );

        Console.WriteLine(
            $"Треугольник с сторонами {a}, {b}, {c} является прямоугольным: {triangle.IsRightAngled()}"
        );

        // Демонстрация работы с вычислением площади фигуры через интерфейс
        IShape shape1 = new Circle(10);
        IShape shape2 = new Triangle(5, 12, 13);

        Console.WriteLine(
            $"Площадь круга с радиусом 10 = {ShapeAreaCalculator.CalculateArea(shape1)}"
        );
        Console.WriteLine(
            $"Площадь треугольника с длинами сторон 5, 12, 13 = {ShapeAreaCalculator.CalculateArea(shape2)}"
        );
    }
}
