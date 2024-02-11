using ShapeCalculation.Interfaces;

namespace ShapeCalculation.Shapes;

public class TriangleShape : IShape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public TriangleShape(double a, double b, double c)
    {
        ValidateSides(a, b, c);

        _a = a;
        _b = b;
        _c = c;
    }

    private void ValidateSides(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Длины треугольника должны быть больше 0");

        if ((a >= b + c) || (b >= a + c) || (c >= a + b))
            throw new ArgumentException("Треугольник c такими сторонами невозможен.");
    }

    public bool IsRightTriangle()
    {
        double[] sides = new double[] { _a, _b, _c };

        Array.Sort(sides);
        Array.Reverse(sides);

        if (Math.Pow(sides[0], 2) == (Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)))
            return true;

        return false;
    }

    public double CalculateArea()
    {
        double p = (_a + _b + _c) / 2;

        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }
}