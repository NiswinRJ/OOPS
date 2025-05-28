class CircleCube : IArea,IVolume
{
    public void CalcArea(double Radius)
    {
        double pie=3.14;
        double result;
        result=pie*Radius*Radius;
        Console.WriteLine($"Area of Circle: {0}",result);
    }

    public void CalcVolume(int side)
    {
        int result;
        result=side*side*side;
        Console.WriteLine($"Volume of Circle: {0}",result);
    }
}