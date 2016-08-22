using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Switch_Statements_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //switch on menu options
            Console.WriteLine("Which option would you prefer: A, B, or C?");
            string userValue = Console.ReadLine();
            string message = "";

            switch (userValue)
            {
                case "A":
                    message = "You selected A: You die from dysentery.";
                    break;

                case "B":
                    message = "You selected B: Your wagon is attacked by Indians.";
                    break;

                case "C":
                    message = "You selected C: Congratulations! You made it to Oregon!";
                    break;
                    
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
