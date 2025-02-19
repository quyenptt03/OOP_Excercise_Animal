using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

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

        public void ShowInfo()
        {
            Console.WriteLine("Animals in the zoo: ");
            foreach(Animal a in zoo)
            {
                Console.WriteLine(a.showInfo());
            }
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

        public void WriteJSONFile(string filename)
        {
            string json = JsonConvert.SerializeObject(
                zoo.Select(animal => {
                    var jsonAnimal = JObject.FromObject(animal);

                    jsonAnimal.Add("Type", animal.GetType().Name); 
                    return jsonAnimal;
            }), Formatting.Indented);

            File.WriteAllText(filename, json);
        }

        public void ReadJSONFile(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File doesn't exists");
            }

            string json = File.ReadAllText(filename);
            JArray jsonArray = JArray.Parse(json);

            List<Animal> animals = new List<Animal>();

            foreach (JObject obj in jsonArray)
            {
                string type = obj["Type"].ToString();

                switch (type)
                {
                    case "Lion":
                        zoo.Add(new Lion(obj["Name"].ToString(), (int)obj["Age"], obj["Species"].ToString(), obj["Color"].ToString()));
                        break;
                    case "Elephant":
                        zoo.Add(new Elephant(obj["Name"].ToString(), (int)obj["Age"], obj["Species"].ToString()));
                        break;
                    case "Monkey":
                        zoo.Add(new Monkey(obj["Name"].ToString(), (int)obj["Age"], obj["Species"].ToString()));
                        break;
                    default:
                        throw new Exception($"Unknown animal type: {type}");
                }
            }
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
