class House{
    
    public string propertyNumber;
    public string propertyLocation;
    public int propertyPrice;


    public House(string propertyNumber, string propertyLocation,int propertyPrice){
        this.propertyNumber = propertyNumber;
        this.propertyLocation = propertyLocation;
        this.propertyPrice = propertyPrice;
    }
}
class Virudhunagar{
    static void Main(){
        House house = new House("24/k","Virudhunagar",5000000);
        System.Console.WriteLine(house.propertyNumber);
    }
}