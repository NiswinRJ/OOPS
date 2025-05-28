using System;
using System.Runtime.InteropServices;
 
class Animal{
    public virtual void MakeSound(){
        Console.WriteLine("Animals sound is ooooooooo");
    }
    protected void Sleep(){
        Console.WriteLine("Animal's sleep is the cutest thing ");
    }
}
class Dog : Animal{
    public override void MakeSound()
    {
        Sleep();
        Console.WriteLine("Dog Barks....");
    }
}
class Program{
    static void Main(string[] args){
        Animal animal= new Animal();
        animal.MakeSound();
        Animal dog = new Dog();
        dog.MakeSound();
    }
}