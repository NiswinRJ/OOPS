using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("I can eat");
    }
}

class Dog : Animal
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
        myDog.Bark(); 

        Console.ReadKey();
    }
}
