using System;

interface IAnimal
{
    void Bark();
}

class Dog : IAnimal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal dog = new Dog();
        dog.Bark();
    }
}
