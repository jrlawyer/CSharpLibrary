using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Array_with_Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new[] { "Jen", "James", "Judy", "Tony", "Steph", "Anthony", "Amond", "Eli", "Jim", };
            foreach (var ch in myFamily)
            {
                Console.WriteLine(ch);
            }
            Console.ReadLine();

        }
        
    }
}
