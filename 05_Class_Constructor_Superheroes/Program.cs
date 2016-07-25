using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class_Constructor_Superheroes
{
    class Program
    {
        static void Main(string[] args)
        {
            //new instances of class
            var b = new SuperHeroes("Batman", Gender.Male, "Awesomeness", 10);
            var f = new SuperHeroes("Flash", Gender.Male, "Speedy-ness", 7);
            var s = new SuperHeroes("Spiderman", Gender.Male, "Spidey-sense", 9);
            var sman = new SuperHeroes("Superman", Gender.Male, "Strength", 1);
            var w = new SuperHeroes("WonderWoman", Gender.Female, "Awesomeness", 10);
           

            Console.WriteLine(b);
            b.Thanks();

            Console.WriteLine(f);
            f.Thanks();

            Console.WriteLine(s);     
            s.Thanks();

            Console.WriteLine(s);
            w.Thanks();

            sman.Ability();
            b.Ability();
            f.Ability();
            s.Ability();
            w.Ability();

            w.GirlPower();

            Console.ReadLine();
        }
    }

    //separate file


    public enum Gender { Male, Female};

    public class SuperHeroes
    {
        //Constructor
        public SuperHeroes(string name, Gender gender, string power, int level)
        {
            Name = name;
            Gender = gender;
            Power = power;
            Level = level;
        }


        //properties
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Power { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"It's {Name}! He will save us with his {Power}!";
        }

        public void Thanks()
        {
            Console.WriteLine($"Thank you {Name} for saving us!");
        }

        public void Ability()
        {
            if (Level < 5)

            Console.WriteLine($"Geez {Name}, you are not the SuperHero I thought you were.");

            else

               Console.WriteLine($"You are the best Superhero ever, {Name}!");
        }

        public void GirlPower()
        {
            if (Gender == Gender.Female)
            {
                Console.WriteLine($"Hey {Name}! You go, girl!"); 

            }

        }

    }
}
