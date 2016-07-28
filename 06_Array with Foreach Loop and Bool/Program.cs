using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Array_with_Foreach_Loop_and_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
          
            FiveStarTest("S");  //Calling method

        }

        static void FiveStarTest(string startsWith)  //void method with static access modifier
        {
            bool foundName = false;  //bool that sets state to false; bool was added to create 2 separate states, one where a name had been found and one where it hadn't

            var FiveStar = new List<string> { "Nicole", "Sean", "Jeff", "Amanda", "Austin", "Andre", "London" };  //list

            foreach (var instructor in FiveStar)  //foreach loop
            {
                if (instructor.StartsWith(startsWith))  //if statement and use of ".StartsWith"
                {
                    foundName = true;  //if bool is true, print instructor name
                    Console.WriteLine(instructor);
                }
            }

            if (!foundName)  //if not foundName, print message
            {
                Console.WriteLine("Sorry, these aren't the droids you're looking for.");
            }

            Console.ReadLine();
        }

    }
}



