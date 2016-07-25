using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals kangaroo = new Animals("Kangaroo");
            Animals kangaroo2 = new Animals("Kangaroo", "Mammal");
            Animals platypus = new Animals("Playtpus", "Semi Aquatic Mammal");
            Animals platypus2 = new Animals("Playtpus", "Semi Aquatic Mammal", 4);


            Console.WriteLine(platypus);
            Console.ReadLine();
        }
    }
    
    
    public class Animals
    {
        //Constructor 1:  multiple constructors means more ways to create objects, variety.  Use to create a user with less information if you don't have everything.
        public Animals(string name)
        {
            this.Name = name;
        }
        
        //Constructor 2:
        public Animals(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        //Constructor 3:
        public Animals(string name, string type, int numberOfLegs)
        {
            this.Name = name;
            this.Type = type;
            this.NumberOfLegs = numberOfLegs;
        }
        //properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfLegs { get; set; }

        public override string ToString()
        {
            return ($"{Name}: {Type} with {NumberOfLegs} legs");
        }

    }

}
