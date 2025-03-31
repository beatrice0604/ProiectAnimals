using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Otter : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine($"{GetType().Name} makes sound: miiip miiip miiip");
        }
    }
}
