using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_lab_1_Ardena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the product you want to purchase: ");
            string product = Console.ReadLine();

            Console.Write("Enter the number of "+ product +  " you want to purchase: ");
            int pnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("The total price of " + pnum + " " + product + ": " );
            double pprice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("the value of the converted price is: " + Math.Round(pprice) );


        }
    }
}
