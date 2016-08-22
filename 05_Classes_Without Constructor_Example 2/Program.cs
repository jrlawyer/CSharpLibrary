using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes_Without_Constructor_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //new instance of "SoccerPlayer"
            SoccerPlayer Paul = new SoccerPlayer();
            Paul.Name = "Paul O'Conner";
            Paul.Number = 13;
            Paul.GoalsScored = 25;
            Paul.Nation = "United States";
            //Calling method PrintInfo
            Paul.PrintInfo();
            Paul.NameNation();

            SoccerPlayer Jen = new SoccerPlayer();
            Jen.Name = "Jen Lawyer";
            Jen.Number = 27;
            Jen.GoalsScored = 30;
            Jen.Nation = "United States";
            Jen.PrintInfo();
            Jen.NameNation();
            
            Console.ReadLine();

        }
    }


    //class
    public class SoccerPlayer
    {
        //properties
        public string Name { get; set; }
        public int Number { get; set; }
        public int GoalsScored { get; set; }
        public string Nation { get; set; }
        
        //methods
        public void PrintInfo()
        {
            Console.WriteLine($"Player Name: {Name}, Nation: {Nation}, Player Number: {Number}, Goals Scored: {GoalsScored}");
        }

        public void NameNation()
        {
            Console.WriteLine($"Player Name: {Name}, Nation: {Nation}");
        }


    }
}
