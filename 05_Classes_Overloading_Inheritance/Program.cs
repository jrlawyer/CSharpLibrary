using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes_Overloading_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            JawsCharacter brody = new JawsCharacter("Brody", "Chief of Police");
            JawsCharacter hooper = new JawsCharacter("Hooper", "Marine Biologist");
            JawsStar bruce = new JawsStar("Bruce", "Shark", true);
            JawsCharacter quint = new JawsCharacter("Quint", "Sharker");

            brody.SayInfo();
            Console.WriteLine(brody);

            hooper.SayInfo();
            Console.WriteLine(hooper);

            bruce.SayInfo();
            Console.WriteLine(bruce);
            bruce.NomNom();
            bruce.SayName();

            quint.SayName();
            quint.SayInfo();

            
            Console.ReadLine();
        }

        
    }

    public class JawsCharacter
    {
        public JawsCharacter (string name)
        {
            this.Name = name;
        }

        public JawsCharacter (string name, string occupation)
        {
            this.Name = name;
            this.Occupation = occupation;
        }

        public string Name { get; set; }
        public string Occupation { get; set; }

        public override string ToString()
        {
            return ($"{Name}: {Occupation}");
        }

        public void SayName()
        {
            Console.WriteLine($"Hi, my name is {Name}.");
        }

        public void SayInfo()
        {
            Console.WriteLine ($"Hi, my name is {Name} and I am a {Occupation}.");
        }

    }

    public class JawsStar : JawsCharacter 
    {
        public JawsStar (string name, string occupation, bool isAShark)
            : base(name, occupation)
        {
            this.IsAShark = isAShark;
        }

        public bool IsAShark { get; set; }

        public void NomNom()
        {
            if (IsAShark == true)
            {
                Console.WriteLine($"Time for a Crunchy Lunchy!");
            }
        }

    }
}
