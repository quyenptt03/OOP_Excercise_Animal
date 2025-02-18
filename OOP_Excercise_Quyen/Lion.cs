using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise_Quyen
{
    class Lion : Animal
    {
        public Lion(string name, int age, string species) : base(name, age, species)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("Lion make sound....");
        }

        public void Hunting(Animal prey)
        {
            Console.WriteLine($"{Name} hunts {prey.Name}");
        }

    }
}
