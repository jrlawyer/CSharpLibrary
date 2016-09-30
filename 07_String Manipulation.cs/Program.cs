using System;

namespace _07_String_Manipulation.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //escape sequences for back slash, quotes, a new line
            //string myString = "Go to your C:\\ drive";
            //string myString = "My \"so called\" life";
            //string myString = "What if I need \n a new line?";

            //Formatting options - string.Format msdn
            //string myString = string.Format("{0}!", "Bonzai");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");
            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 123456789);
            //string myString = string.Format("Phone number: {0:(###)###-####}", 1234567890);
            //string myString = string.Format("{0:P}", .123);

            /*g = "";

            for (int i = 0; i < 100; i++)

            {
                //myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();


            } */

            /*
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            } */

            //pulling characters from string
            string myString = "  All I can say is that my life is pretty plain  ";

            //myString = myString.Substring(5, 14);

            //myString = myString.ToUpper();

            //myString = myString.Replace(" ", "--");

            myString = String.Format("Length before {0} -- After: {1}",
                myString.Length, myString.Trim().Length);
            
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
