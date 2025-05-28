public abstract class Shapes{
    public abstract void Display();
}

public class Square:Shapes{
    public override void Display()
    {
        Console.WriteLine("Printing Square");
    }
}
public class Rectangle:Shapes{
    public override void Display()
    {
        Console.WriteLine("Printing Rectangle");
    }
}

class Excercise{
    static void Main(){
        Square drawshape=new Square();
        drawshape.Display();
        Rectangle draw=new Rectangle();
        draw.Display();
        Console.ReadKey();
    }
}