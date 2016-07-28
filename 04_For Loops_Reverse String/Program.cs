using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_For_Loops_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello world";
            string reverseString = "";

            for (var i = myString.Length - 1; i >= 0; i--)
            {
                reverseString += myString[i];
            }

            Console.WriteLine(reverseString);
            Console.ReadLine();
        }
    }
}
