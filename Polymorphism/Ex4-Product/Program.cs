class Product {
    public string name;
    protected double price;
    public Product (){
        Console.WriteLine("This is a Default Constructor.....");
    }
    public Product(string name){
        this.name = name;
        Console.WriteLine("The name is : "+name);
    }
    public Product(string name, double price){
        this.name = name;
        this.price = price;
        Console.WriteLine("Name is "+name);
        Console.WriteLine("Price is : "+price);
    }
}
class Program{
    public static void Main(string[] args) {
        Product product = new Product();
        Product product1= new Product("Rajesh");
        Product product2= new Product("Suresh",1000.89);
    }
}