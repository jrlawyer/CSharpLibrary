using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b;

            x = 3; 
            y = 4;
            a = 10;
            b = 5;

            //Addition operator

            x = 3 + 4;

            //Substraction operator

            x = 4 - 3;

            //Multiplication operator

            x = 10 * 5;

            //Division operator

            x = 10 / 5;


            //Operators to evaulate values...

            //Equality operator
            if (x == y)
            {}

            //Greater than operaor
            if (x > y)
            { }

            //Less than operator
            if (x < y)
            { }

            //Greater than or equal to operaor
            if (x >= y)
            { }

            //Less than or equal to operator
            if (x <= y)
            { }


            //Conditional operators

            //Conditional AND
            if ((x > y) && (a < b))
            {

            }

            //Conditional OR
            if ((x > y ) || (a > b))
            {

            }

            //IN-LINE conditional 

            string message = (x == 1) ? "Car" : "Boat";


        }
    }
}
