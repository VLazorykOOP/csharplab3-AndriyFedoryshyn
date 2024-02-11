namespace tests;
using Lab3CSharp;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var rectangles = new Rectangle[2];
        rectangles[0] = new Rectangle(2, 2, 1);
        rectangles[1] = new Rectangle(2, 3, 2);
        Assert.Equal(8, rectangles[0].CalculatePerimeter());
        Assert.Equal(4, rectangles[0].CalculateArea());
        Assert.True(rectangles[0].IsSquare());
        Assert.Equal(10, rectangles[1].CalculatePerimeter());
        Assert.Equal(6, rectangles[1].CalculateArea());
        Assert.False(rectangles[1].IsSquare());
    }

    [Fact]
    public void Test2()
    {
        var rectangles = new Rectangle[2];
        rectangles[0] = new Rectangle(2, 2, 1);
        rectangles[1] = new Rectangle(2, 3, 2);
        Assert.Equal(8, rectangles[0].CalculatePerimeter());
        Assert.Equal(4, rectangles[0].CalculateArea());
        Assert.True(rectangles[0].IsSquare());
        Assert.Equal(10, rectangles[1].CalculatePerimeter());
        Assert.Equal(6, rectangles[1].CalculateArea());
        Assert.False(rectangles[1].IsSquare());
    }
}