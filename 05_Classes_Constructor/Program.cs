using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            FitnessClasses zumba = new FitnessClasses("Zumba", 500);
            FitnessClasses yoga = new FitnessClasses("Yoga", 25);
            FitnessClasses crossfit = new FitnessClasses("Crossfit", 4);



            Console.WriteLine(yoga);
            Console.WriteLine(zumba);
            Console.WriteLine(crossfit);
            Console.ReadLine();
        }
    }

    /// <summary>
    /// pretend this class is in a separate file
    /// </summary>
    public class FitnessClasses
    {
        //Constructor with parameters
        public FitnessClasses(string title, int numberOfStudents)
        {   //tying parameters and properties to each other
            this.Title = title;
            this.NumberOfStudents = numberOfStudents;
        }
        //properties
        public string Title { get; set; }
        public int NumberOfStudents { get; set; }

        public override string ToString()
        {
            return $"Class: {Title}, Participants: ({NumberOfStudents})";
        }



    }
}


/*CONSTRUCTOR NOTES:
Looks like a function but no return type.
Name matches name of class.
Help set default values.
Don't always need them in the class but they create safety.
Can make code sleeker so that you aren't writing details for each instance multiple times.
 */