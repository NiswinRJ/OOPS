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

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("I can meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();
        
        myDog.Eat();  // Inherited from Animal
        myDog.Bark(); // Dog's method
        
        myCat.Eat();  // Inherited from Animal
        myCat.Meow(); // Cat's method

        Console.ReadKey();
    }
}
