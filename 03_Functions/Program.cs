using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Functions
{
    class Program
    {
        static void Main(string[] args)  //void methods don't return a value.  
        {
            //string myValue = superSecretFormula("there"); //calling function and providing parameter, overrloaded function - different number of parameters or data type of parameters
            string myValue = superSecretFormula("sunshine");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula()  //original function
        {
            return "Hello World!";
        }

        private static string superSecretFormula(string name)  //function, aka method, that accepts a parameter
        {
            return String.Format($"Hello, {name}!");  //string interpolation
        }
    }
}

