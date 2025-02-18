using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise_Quyen
{
    class Zoo
    {
        public delegate void ZooMemberChangedHandler(object sender, ZooMemberChangedEventArgs e);

        public event ZooMemberChangedHandler OnAnimalAdded;

        List<Animal> zoo = new List<Animal>();

        public void Add(Animal animal)
        {
            zoo.Add(animal);
            OnZooMemberChanged(new ZooMemberChangedEventArgs(animal));
        }

        public override string ToString()
        {
            string str = "Animals in the zoo:\n";
            foreach (var animal in zoo)
            {
                str += animal.Name + "\t";
            }
            return str;
        }

        protected virtual void OnZooMemberChanged(ZooMemberChangedEventArgs e)
        {
            OnAnimalAdded?.Invoke(this, e);
        }

        public List<Animal> Filter(int age, string speciesType)
        {
            return zoo.Where(animal => animal.Age >= age && animal.Species == speciesType).ToList();

        }

        public List<Animal> Filter(int age)
        {
            return zoo.Where(animal => animal.Age >= age).ToList();
        }
        public List<Animal> Filter(string speciesType)
        {
            return zoo.Where(animal => animal.Species == speciesType).ToList();
        }
    }

    public class ZooMemberChangedEventArgs : EventArgs
    {
        public Animal NewAnimal { get; }

        public ZooMemberChangedEventArgs(Animal newAnimal)
        {
            this.NewAnimal = newAnimal;
        }
    }
}
