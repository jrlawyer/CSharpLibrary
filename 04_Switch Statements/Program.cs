using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Switch_Statements
{
    public class Program
    {
        public static void Main(string[] args)
            //with switch, only one can be correct; with if statements, more than one can be correct.  Exclusivity for switch case.  
        {
            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();
            string message = "";

            switch (userValue)
            {
                case "1":
                    message = "You won a new car!";
                    break;  //jump out of code block.

                case "2":
                    message = "You won a new boat!";
                    break;

                case "3":
                    message = "You won a new cat!";
                    break;

                default:
                    message = "Sorry, we didn't understand your response. You lose.";
                    break;

            }
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
