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
            elephant.makeSound();
            elephant.showInfo();
            Console.WriteLine("Name: " + elephant.Name);

            Console.WriteLine("==============");

            Animal monkey = new Elephant("Monkey 1", 5, "Herbivore");
            monkey.makeSound();
            monkey.showInfo();

            Console.WriteLine("==============");

            Animal lion = new Lion("Lion 1", 10, "Carnivore");
            lion.makeSound();
            lion.showInfo();

            if (lion is Lion realLion)
            {
                realLion.Hunting(monkey);
            }
        }
    }
}
