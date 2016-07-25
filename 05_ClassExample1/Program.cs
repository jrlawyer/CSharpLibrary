using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ClassExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car angiesCar = new Car();
            angiesCar.Make = "Toyota";
            angiesCar.Year = 2007;
            angiesCar.PrintYear();
            Console.WriteLine($"Angie owns a {angiesCar.Year} {angiesCar.Make}.");
            


            Car zachsCar = new Car();
            Car jensCar = new Car();
            jensCar.Make = "Ford";
            jensCar.Year = ;


            Car paulsCar = new Car();
            paulsCar.Make = "Maserati";
            paulsCar.Year = 2016;
            paulsCar.PrintYear();

            Console.ReadLine();

        }
    }
    

    //Separate File
    public class Car
    {   //Properties
        public int VIN { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsAutomatic { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }

        //Method

        public void PrintYear()
        {
            Console.WriteLine("The year of the car is {0}.", Year);
        }
    }

}
