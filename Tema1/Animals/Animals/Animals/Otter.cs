using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Otter : IAnimal
    {
        public void makeSound()
        {
            Console.WriteLine("Otter makes sound: miiip miiip miiip");
        }
    }
}
