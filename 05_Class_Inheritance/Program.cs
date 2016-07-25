using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal(); //cannot create a new instance of an abstract class.
            //animal.Name = "Generic Animal";
            //animal.SayName();

            //Make a person class as a parent class
            //Give it 4-6 properties
            //create 3 sub classes off of person
            //Teacher, Student, TeachingAid



            Bear winnie = new Bear();
            winnie.Name = "Winnie the Pooh";
            winnie.AmountOfHoneyEaten = 1000;
            winnie.SayName();


            Rabbit roger = new Rabbit();
            roger.Name = "Roger the Rabbit";
            roger.HasFluffyTail = true;
            roger.SayName();

            //Console.WriteLine(winnie.AmountOfHoneyEaten);
            //Console.WriteLine(roger.HasFluffyTail);
            Console.ReadLine();
        }
    }

    public abstract class Animal
    {
        //property
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string FavoriteFood { get; set; }



        //Methods
        public virtual void SayName()
        {
            Console.WriteLine("I am an animal.");
        }
        
        
    }

    public class Bear : Animal //Bear inherits from Animal
    {
        public int AmountOfHoneyEaten { get; set; }

        //method
        public override void SayName()
        {
            Console.WriteLine("I am a bear.");
        }

    }

    public class Rabbit : Animal
    {
        public bool HasFluffyTail { get; set; }

        public override void SayName()
        {
            Console.WriteLine("My name is Roger Rabbit.");
        }
    }

}
