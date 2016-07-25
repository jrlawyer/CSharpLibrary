using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BasicTypes_Enums
{
    enum Gender { Unknown, Male, Female }

    class Program
    {
        static void Main(string[] args)
        {
            //Enumerations:  labels associated with base type and need to be placed outside the main function.  You can print to console by either creating
            //a variable or by having "Console.WriteLine(DayOfWeek.Monday); 
            //

            //DayOfWeek day = DayOfWeek.Monday;
            //Console.WriteLine(day);
            //Console.ReadLine();


            //Gender gender = Gender.Female;
            Console.WriteLine(Gender.Male);
            Console.ReadLine();

            //Console.WriteLine(Bird.Canary);
            //Console.WriteLine(Bird.Crow);
            //Console.WriteLine(Bird.Seagull);
            //Console.ReadLine();

        }

        //enum DayofWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        //enum Gender { Unknown, Male, Female }
    }
}
