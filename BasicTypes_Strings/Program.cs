using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstName = "Jennifer";
            var LastName = "Lawyer";

            //var Name = FirstName + " " + LastName;  //string concatination
            var Name = $"{FirstName} {LastName}";  //string interpolation
            Console.WriteLine(Name);
            Console.ReadLine();



            /*int x = int.Parse("2010");
            string y = "James";

            var OurAnniversary = ($"{y} and I were married in {x}.");  //string interpolation

            Console.WriteLine(OurAnniversary);
            Console.ReadLine(); */
            /*
            
            
            int x = 2002;
            string y = "James";

            var OurFirstAnniversary = ($"{y} and I met in {x}.");  //string interpolation  
            Console.WriteLine(OurFirstAnniversary);
            Console.ReadLine();
            */
        }
    }
}
