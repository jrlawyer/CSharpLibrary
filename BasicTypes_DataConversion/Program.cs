using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes_DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //data conversion

            
            int x = 7;
            string y = "5";
            string myFirstTry = x.ToString() + y;  //ToString; string concatination

            //int mySecondTry = x + int.Parse(y);  //Parse; converting string to int

            Console.WriteLine(myFirstTry);
            //Console.WriteLine(mySecondTry);

            Console.ReadLine();
            

            int a = 7;
            string b = "123";
            
            int result;
            var MyThirdTry = int.TryParse(b, out result); //TryParse:  returns a boolean value and an int value, needs container for both, int result for int 
            var TryAgain = a + result;

            //Console.WriteLine(MyThirdTry);
            Console.WriteLine(TryAgain);
            Console.ReadLine();
            
        }
    }
}
