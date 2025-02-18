using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise_Quyen
{
    class Monkey : Animal
    {
        public Monkey(string name, int age, string species) : base(name, age, species)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("Monkey make sound...");
        }

    }
}
