using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string userValue = Console.ReadLine();

            int result;
            var boolAge = int.TryParse(userValue, out result);
            var userAge = result;

            string message = "";
            
            if (userAge >= 21)
            {
                message = ("You can vote and drink!");
            }

            else if (userAge >= 18 && userAge < 21)
            {
                message = ("You can vote!");
            }

            else
            {
                message = ("You are too young to have any fun. :(");
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
