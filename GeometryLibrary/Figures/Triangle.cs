namespace GeometryLibrary.Figures;

public class Triangle : IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        // Проверка, чтобы все стороны были положительными
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Стороны треугольника должны быть положительными.");
        }

        // Проверка на существование треугольника
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("Указанные стороны не могут образовать треугольник.");
        }

        A = a;
        B = b;
        C = c;
    }

    // Метод для вычисления площади по формуле Герона
    public double CalculateArea()
    {
        double semiPerimeter = (A + B + C) / 2;
        return Math.Sqrt(
            semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C)
        );
    }

    // Метод для проверки, является ли треугольник прямоугольным
    public bool IsRightAngled()
    {
        double[] sides = { A, B, C };
        Array.Sort(sides);

        // Проверка теоремы Пифагора
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))
            < Double.Epsilon;
    }
}
