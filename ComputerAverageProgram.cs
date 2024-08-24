using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ComputerAverageApp
{
    internal class ComputerAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());

            double sum = a + b + c + d + e;
            double avg = sum / 5;

            double roundavg = Math.Round(avg, 0);
            


            Console.WriteLine("The average is " + avg + " and round off to " + roundavg);

            Console.ReadLine();


        }
    }
}
