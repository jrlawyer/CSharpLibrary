using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Example_1
{
    class Program
    {
        private static void Main(string[] args)
        {
            
            /*int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;*/

            var numbers = new[] {4, 5, 8, 15, 16, 23};

            Console.WriteLine(numbers.Length);
            Console.ReadLine();

            /*
            int[] numbers = new int[] {4, 8, 15, 16, 23, 42};
            

            var myArray = new[] {4, 8, 15, 16, 23};
            
            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine(); 

            string[] names = new string[] {"Eddie", "Alex", "Michael", "David", "Lee"};

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            string zig = "You can get what you want out of life" +
                         "if you help enough other people get what they want.";

            //divide string into chars(part of charArray)
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            //takes each element in array and reverses its position.
                           
            foreach(char zigChar in charArray) 
                Console.Write(zigChar);
            //writes on horizontal, instead of using breaks.

            Console.ReadLine();*/



        }
    }
}
