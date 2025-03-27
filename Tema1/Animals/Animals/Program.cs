
using Animals;
using Animals.Animals;
using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        Rooster rooster = new Rooster();    
        Cat cat = new Cat();    
        Otter otter = new Otter();  

        //var animals = new List<Animal>();
        //animals.Add(rooster);   
        //animals.Add(cat);   
        //animals.Add(otter);  

        var animalsI  = new List<IAnimal>();
        animalsI.Add(rooster);
        animalsI.Add(cat);
        animalsI.Add(otter);

        foreach (var animal in animalsI)
        {
            animal.makeSound();
        }
    }
}