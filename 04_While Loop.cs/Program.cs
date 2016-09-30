using System;
using System.IO;

namespace _04_While_Loop.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO namespace, Stream reader will open txt file
            StreamReader myReader = new StreamReader("Value.txt");
            string line = "";

            while (line != null)  //unknown value, an empty string is not null, continue until end of file.
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close(); //closing the file
            Console.ReadLine();
        }
    }
}
