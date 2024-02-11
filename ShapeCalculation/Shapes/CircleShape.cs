using ShapeCalculation.Interfaces;

namespace ShapeCalculation.Shapes;

public class CircleShape : IShape
{
    private readonly double _r;

    public CircleShape(double r)
    {
        if (r <= 0)
            throw new ArgumentException("Длина радиуса должна быть больше 0");

        _r = r;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_r, 2);
    }
}