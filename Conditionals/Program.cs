using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press Enter");
            //string userValue;
            //    userValue = Console.ReadLine();
            //Console.WriteLine("You typed:" + userValue);

            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            //    string message = "";

            //    if (userValue == "1")  //decision statemen...aka conditional
            //        message = "You won a new car!";

            //    else if (userValue == "2")
            //        message = "You won a new boat!";

            //    else if (userValue == "3")
            //        message = "You won a new cat!";

            //    else  //if no other conditions are met, execute this.
            //        message = "Sorry, we didn't understand.  You lose!";


            //    Console.WriteLine(message);

            string message = (userValue == "1") ? "Boat" : "strand of lint";  //conditional operator: true or false
            //Console.WriteLine("You won a {0}", message);  //string replacement syntax
            Console.WriteLine($"You won a {message}!");


            Console.ReadLine();
        }
    }
}
