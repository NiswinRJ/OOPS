using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("I can eat");
    }
}

class Mammal : Animal
{
    public void Walk()
    {
        Console.WriteLine("I can walk");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("I can bark");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat();  
        myDog.Walk(); 
        myDog.Bark(); 

        Console.ReadKey();
    }
}
