using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class_Constructor_Dance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dance rumba = new Dance("Rumba", "Rhythm", true, 5);
            rumba.DanceInfo();
            rumba.DanceIntensity();

            Dance ecSwing = new Dance("E.C. Swing", "Rhythm", false, 3);
            ecSwing.DanceType();
            ecSwing.DanceIntensity();

            Dance foxtrot = new Dance("Foxtrot", "Smooth", true, 7);
            foxtrot.DanceInfo();
            foxtrot.DanceType();
            foxtrot.DanceIntensity();

            Console.ReadLine();
        }

        
    }


    //class
    public class Dance
    {
        //constructor
        public Dance(string name, string type, bool isFun, int intensity)
        {
            //fields
            this.Name = name;
            this.Type = type;
            this.IsFun = isFun;
            this.Intensity = intensity;
        }

        //properties
        public string Name { get; set; }
        public string Type {get; set;}
        public bool IsFun { get; set;}
        public int Intensity { get; set; }

        //method

        public void DanceInfo()
        {
            Console.WriteLine($"Dance: {Name}, Type: {Type}, Fun?: {IsFun}");
        }

        public void DanceType()
        {
            Console.WriteLine($"Dance: {Name}, Type: {Type}");
        }

        public void DanceIntensity()
        {
            if (Intensity > 5){
                Console.WriteLine($"This is a more difficult dance; take a break!");
            }

            else if (Intensity == 5)
            {
                Console.WriteLine($"This is a difficult dance; let's try it one more time!");
            }

            else
            {
                Console.WriteLine($"This is an easier dance; work harder!");
            }

        }

    }
}
