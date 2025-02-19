using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise_Quyen
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

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
    }

    public static class AnimalExtentions
    {
        public static string GetAnimalType(this Animal animal)
        {
            return animal.Species;
        }
    }
}
