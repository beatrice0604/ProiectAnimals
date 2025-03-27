using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Cat : IAnimal
    {
        public void makeSound()
        {
            Console.WriteLine("Cat makes sound: Wiwiwiwi");
        }
    }
}
