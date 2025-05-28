using System;

abstract class Animal
{
    public abstract void Sound();
}

class Lion : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Roar");
    }
}

class Tiger : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Growl");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal lion = new Lion();
        lion.Sound();

        Animal tiger = new Tiger();
        tiger.Sound();
    }
}
