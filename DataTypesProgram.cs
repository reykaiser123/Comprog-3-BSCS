﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int piece = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of 6 apples(s): ");
            double prices = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total price of of 6 apple(s): " + prices);

            Console.WriteLine("The value of original price is " + prices);
            Console.WriteLine("The value of converted price is: " + Convert.ToInt32(prices));

            Console.ReadLine();

            
        }
    }
}
