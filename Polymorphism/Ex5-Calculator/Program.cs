class Calculator{
    public int num1;
    public int num2;
    public int num3;
 
    public Calculator(int num1 , int num2){
        this.num1 = num1;
        this.num2 = num2;
        Console.WriteLine("Addition of two numbers ");
        Console.WriteLine(num1+num2);
 
    }
    public Calculator(int num1, int num2,int num3){
        this.num1 = num1;
        this.num2 = num2;
        this.num3 = num3;
        Console.WriteLine("Addition of three numbers using Constructor Overloading");
        Console.Write(num1+num2+num3);
    }
 
}
class Program{
    public static void Main(string[] args) {
        Calculator calculator = new Calculator(2233,890);
        Calculator calculator1 = new Calculator(345,2442,322);
       
 
    }
}