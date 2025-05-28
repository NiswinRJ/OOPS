class MakingUseOfAccessSpecifiers{

    int propertyNumber;

    public MakingUseOfAccessSpecifiers(){
        propertyNumber=99902020;
    }
    public MakingUseOfAccessSpecifiers(int propertyNumber){
        this.propertyNumber=propertyNumber;
    }


    //Accessible anywhere
    public void PublicMethod(){
        Console.WriteLine("This is Public Method use.....");
    }

    //Accessible only within the class
    private void PrivateMethod(){
        Console.WriteLine("This is a Private Method use.....");
    }


    //Accessible within the class and derived class only
    protected void ProtectedMethod(){
        Console.WriteLine("This is Protected Method use.....");
    }


    //Accessible within the same Assembly file
    internal void InternalMethod(){
        Console.WriteLine("This is a Internal Method use.....");
    }


    //Accessible within the same protected access-Assembly file
    protected internal void ProtectedInternalMethod(){
        Console.WriteLine("This is a Protected Internal Method use.....");
    }

}


class TestAccess{
    static void Main(string[] args){
        MakingUseOfAccessSpecifiers myInstance=new MakingUseOfAccessSpecifiers();
        MakingUseOfAccessSpecifiers myInstance1=new MakingUseOfAccessSpecifiers(5678);
    }
}
    
