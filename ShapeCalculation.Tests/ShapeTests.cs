using ShapeCalculation.Shapes;

namespace ShapeCalculation.Tests;

public class ShapeTests
{
    [Test]
    public void CircleAreaCalculation()
    {
        var circle = new CircleShape(5);
        double expectedArea = Math.PI * Math.Pow(5, 2);
        Assert.AreEqual(expectedArea, circle.CalculateArea(), 0.0001);
    }

    [Test]
    public void TriangleAreaCalculation()
    {
        var triangle = new TriangleShape(3, 4, 5);
        
        double expectedArea = 6;
        
        Assert.AreEqual(expectedArea, triangle.CalculateArea(), 0.0001);
    }

    [Test]
    public void RightAngledTriangleCheck()
    {
        var rightTriangle = new TriangleShape(3, 4, 5);
        var nonRightTriangle = new TriangleShape(2, 4, 5);

        Assert.IsTrue(rightTriangle.IsRightTriangle());
        Assert.IsFalse(nonRightTriangle.IsRightTriangle());
    }

    [Test]
    public void NotValidTriangleSidesException()
    {
        Assert.Throws<ArgumentException>(() => new TriangleShape(1, 2, 6));
    }
    
    [Test]
    public void IsSomeSideIsZeroException()
    {
        Assert.Throws<ArgumentException>(() => new TriangleShape(1, 0, 6));
    }
}