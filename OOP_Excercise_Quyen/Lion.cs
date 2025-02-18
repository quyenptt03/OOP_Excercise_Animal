using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise_Quyen
{
    class Lion : Animal
    {
        private string color;

        public string Color
        {

            get { return color; }
            set { color = value; }
        }

        public Lion(string name, int age, string species, string color) : base(name, age, species)
        {
            Color = color;
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
