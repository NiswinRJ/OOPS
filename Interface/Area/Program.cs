interface IArea{
    void CalcArea(double Radius);
}

class Program{
    static void Main(string[] args){
        CircleCube cc=new CircleCube();
        cc.CalcArea(56);
        cc.CalcVolume(44);
        Console.ReadKey();
    }
}