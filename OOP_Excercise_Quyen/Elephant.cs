using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise_Quyen
{
    class Elephant : Animal
    {
        public Elephant(string name, int age, string species) : base(name, age, species)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("Elephant make sound...");
        }



    }
}
