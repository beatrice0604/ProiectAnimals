
using Animals;
using Animals.Animals;
using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        var animals = new List<IAnimal>()
        {
            new Rooster(),
            new Cat(),
            new Otter()
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}