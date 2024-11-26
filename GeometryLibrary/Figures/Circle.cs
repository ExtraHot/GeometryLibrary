namespace GeometryLibrary.Figures;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Радиус не может быть отрицательным.");
        }
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    
    
}