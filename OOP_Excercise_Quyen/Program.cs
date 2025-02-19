using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise_Quyen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal elephant = new Elephant("Elephant 1", 50, "Herbivore");
            Animal elephant2 = new Elephant("Elephant 2", 20, "Herbivore");
            Animal monkey = new Monkey("Monkey 1", 5, "Herbivore");
            Animal monkey2 = new Monkey("Monkey 2",11, "Herbivore");
            Animal monkey3 = new Monkey("Monkey 3", 9, "Herbivore");
            Animal lion = new Lion("Lion 1", 10, "Carnivore", "Yellow");
            Animal lion2 = new Lion("Lion 2", 20, "Carnivore", "Brown");
            Animal lion3 = new Lion("Lion 3", 25, "Carnivore", "Yellow");

            elephant.makeSound();
            Console.WriteLine(elephant.showInfo());
            Console.WriteLine("Name: " + elephant.Name);
            Console.WriteLine("Type: " + elephant.GetAnimalType());

            Console.WriteLine("==============");

            monkey.makeSound();
            Console.WriteLine(monkey.showInfo());

            Console.WriteLine("==============");

            lion.makeSound();
            Console.WriteLine(lion.showInfo());
            Console.WriteLine("Type: " + lion.GetAnimalType());
            Console.WriteLine("Color: " + ((Lion)lion).Color);
            ((Lion)lion).Hunt(monkey3);
            ((Lion)lion2).Hunt(monkey);

            Console.WriteLine("\n================");
            Zoo zoo = new Zoo();
            zoo.OnAnimalAdded += OnAnimalAdded;

            zoo.Add(elephant);
            zoo.Add(elephant2);
            zoo.Add(monkey);
            zoo.Add(monkey2);
            zoo.Add(monkey3);
            zoo.Add(lion);
            zoo.Add(lion2);
            zoo.Add(lion3);

            Console.WriteLine("================");
            Console.WriteLine(zoo);

            var filterAnimals = zoo.Filter(20, "Herbivore");
            Console.WriteLine("================");
            Console.WriteLine("Herbivore > age 20:");
            foreach(Animal animal in filterAnimals)
            {
                Console.WriteLine(animal.showInfo());
                
            }
        }

       
        private static void OnAnimalAdded(object sender, ZooMemberChangedEventArgs e)
        {
            Console.WriteLine($"New animal added to the zoo: {e.NewAnimal.showInfo()}");
        }
    }
}
