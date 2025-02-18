using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise_Quyen
{
    public abstract class Animal
    {
        string name;
        int age;
        string species;

        protected Animal(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;

        }

        public abstract void makeSound();

        public string showInfo()
        {
            return $"Name: {Name}, Age: {Age}, Species: {Species}";
        }

        public string Name
        {
            get { return name; }
            set { name = value;  }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public string GetAnimalType()
        {
            return $"Type: {Species}";
        }
    }
}
