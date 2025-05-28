using System;

class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal constructor called");
    }

    public void Eat()
    {
        Console.WriteLine("I can eat");
    }
}

class Mammal : Animal
{
    public Mammal() : base()
    {
        Console.WriteLine("Mammal constructor called");
    }

    public void Walk()
    {
        Console.WriteLine("I can walk");
    }
}

class Dog : Mammal
{
    public Dog() : base()
    {
        Console.WriteLine("Dog constructor called");
    }

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
        myDog.Eat();  // Inherited from Animal
        myDog.Walk(); // Inherited from Mammal
        myDog.Bark(); // Dog's method

        Console.ReadKey();
    }
}
