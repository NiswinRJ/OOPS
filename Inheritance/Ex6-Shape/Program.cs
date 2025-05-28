using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle of width {Width} and height {Height}");
    }
}

class Quadrilateral : Shape
{
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }
    public int SideD { get; set; }

    public Quadrilateral(int sideA, int sideB, int sideC, int sideD)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        SideD = sideD;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a quadrilateral with sides {SideA}, {SideB}, {SideC}, and {SideD}");
    }
}

class Square : Quadrilateral
{
    public Square(int side)
        : base(side, side, side, side)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a square with side {SideA}");
    }
}

class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape myShape = new Shape();
        Rectangle myRectangle = new Rectangle(5, 10);
        Quadrilateral myQuadrilateral = new Quadrilateral(4, 5, 6, 7);
        Square mySquare = new Square(4);
        Circle myCircle = new Circle(3);

        myShape.Draw();
        myRectangle.Draw();
        myQuadrilateral.Draw();
        mySquare.Draw();
        myCircle.Draw();

        Console.ReadKey();
    }
}
