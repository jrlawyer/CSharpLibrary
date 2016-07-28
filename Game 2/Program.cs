using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today on a scale of 1 to 5?");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "5")
                message = "That's great!";

            else if (userValue == "4")
                message = "Glad to hear you're doing well!";

            else if (userValue == "3")
                message = "Hang in there!";

            else if (userValue == "2")
                message = "Hope you feel better soon!";

            else if (userValue == "1")
                message = "I'm sorry to hear that.";

            else
                message = "OK, we'll talk later.";


            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
