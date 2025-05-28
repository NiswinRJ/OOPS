using System;

interface IShape
{
    double GetArea();
}

class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width * height;
    }
}

class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Triangle : IShape
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public double GetArea()
    {
        return 0.5 * baseLength * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape rectangle = new Rectangle(5, 7);
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        IShape circle = new Circle(3);
        Console.WriteLine($"Circle Area: {circle.GetArea()}");

        IShape triangle = new Triangle(4, 6);
        Console.WriteLine($"Triangle Area: {triangle.GetArea()}");
    }
}
