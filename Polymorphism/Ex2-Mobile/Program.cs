class Mobile{
    public string phoneNumber;
    public string message;
    public string mediaUrl;
    public byte[] mediaData;
    public string contactName;
    public void SendMessage(string phoneNumber, string message){
        Console.WriteLine("Your phone number : "+phoneNumber+" Tour message is : "+message);
 
    }
    public void SendMessage(string phoneNumber,string message,string mediaUrl){
        Console.WriteLine("Your phone number : "+phoneNumber+"Your message is : "+message+" Your media url is "+mediaUrl);  
    }
    public void SendMessage(string phoneNumber,byte[] mediaData){
        Console.WriteLine("Number and mediadata is :"+ phoneNumber+" Byte Data in string format is : "+BitConverter.ToString(mediaData));
    }
    public void MakeCall(string phoneNumber){
        Console.WriteLine("Phone Number is : "+phoneNumber);
    }
    public void MakeCall(string phoneNumber,string contactName){
        Console.WriteLine("Phone Number is :"+phoneNumber );
        Console.WriteLine("Contact Name is : "+contactName);
 
    }
}
class Program {
    static void Main(string[] args) {
        Mobile mobile = new Mobile();
        byte[] mediaData = {10,20,30,40,50};
        mobile.SendMessage("7904765357","This is a contact number ");
        mobile.SendMessage("8870028715","This is my another contact number ","rajesh.relevantz.com");
        mobile.SendMessage("9842319837",mediaData);
        mobile.MakeCall("8903569185");
        mobile.MakeCall("7339245280","Padma");
    }
 
}


