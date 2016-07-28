using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Conditionals_Game_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month were you born?");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "January")
                message = ("Your birth stone is Garnet.");

            else if (userValue == "February")
                message = ("Your birth stone is Amethyst.");

            else if (userValue == "March")
                message = ("Your birth stone is Aquamarine");

            else if (userValue == "April")
                message = ("Your birth stone is Diamond.");

            else if (userValue == "May")
                message = ("Your birth stone is Emerald.");

            else if (userValue == "June")
                message = ("Your birth stone is Pearl.");

            else if (userValue == "July")
                message = ("Your birth stone is Ruby.");

            else if (userValue == "August")
                message = ("Your birth stone is Peridot.");

            else if (userValue == "September")
                message = ("Your birth stone is Sapphire.");

            else if (userValue == "October")
                message = ("Your birth stone is Opal.");

            else if (userValue == "November")
                message = ("Your birth stone is Topaz.");

            else if (userValue == "December")
                message = ("Your birth stone is Tanzanite");

            else
                message = ("Sorry, I don't understand.");
                string userValueAgain = Console.ReadLine();
                //maybe use a for loop to iterate through options again?
                //for (userValueAgain = "", maybe setup a dictionary with key value as month...iterate over dictionary to produce value.
                //for (var i = 0, i < 10, i++)


            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
