class Print{
    public void Display(string name){
        Console.WriteLine("Print your name: "+name);
    }
    public void Display(int age,double mark){
        Console.WriteLine("Print your age and mark: "+age+""+mark);
    }
}

class Program{
    static void Main(){
        Print print=new Print();
        print.Display("Aashik");
        print.Display(21,76.4);
    }
}
