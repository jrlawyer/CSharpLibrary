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
            var b = new SuperHeroes("Batman", Gender.Male, "Bat Shark Repellent", 10);
            var f = new SuperHeroes("Flash", Gender.Male, "Speed", 7);
            var s = new SuperHeroes("Spiderman", Gender.Male, "Spidey-sense", 9);
            var sman = new SuperHeroes("Superman", Gender.Male, "Boy Scout Manifesto", 1);
            var w = new SuperHeroes("WonderWoman", Gender.Female, "Invisible Plane", 10);
            var r = new Sidekick("Robin", Gender.Male, "Boy Wonder-iness", 1, "Holy underwear, Batman!  The Joker is getting away!");
                
            Console.WriteLine(b);
            b.Thanks();
            b.Intro();

            Console.WriteLine(f);
            f.Thanks();
            f.Intro();

            Console.WriteLine(s);
            s.Thanks();
            s.Intro();

            Console.WriteLine(w);
            w.Thanks();
            w.Intro();

            sman.Ability();
            b.Ability();
            f.Ability();
            s.Ability();
            w.Ability();
            r.Ability();

            w.GirlPower();

            Console.WriteLine(r);
            r.Thanks();
            r.Intro();
            r.HeySidekick();

            Console.ReadLine();
        }
    }

    //separate file


    public enum Gender { Male, Female };

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
            return ($"{Name}: {Power}");
        }

        public void Intro()
        {
            if (Gender == Gender.Male)

                Console.WriteLine($"It's {Name}! He will save us with his {Power}!");

            else
                Console.WriteLine($"It's {Name}! She will save us with her {Power}!");
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


    public class Sidekick : SuperHeroes
    {
        public Sidekick(string name, Gender gender, string power, int level, string catchphrase)
            : base(name, gender, power, level)
        {
            CatchPhrase = catchphrase;
        }

        public string CatchPhrase
        { get; set; }

        public override string ToString()
        {
            return ($"{Name}: {Power}");

        }

        public void HeySidekick()
        {
            if (Name == "Robin")
            {
                Console.WriteLine(CatchPhrase);
            }

        }

    }


}

