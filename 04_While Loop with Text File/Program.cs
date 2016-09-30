using System;
using System.IO;

namespace _04_While_Loop_with_Text_File
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Names.text");

            string line = "";

            while (line != null) 
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            Console.ReadLine();
        }
    }
}
