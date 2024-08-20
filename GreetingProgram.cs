using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            //ask the user to type a user input the program is requesting.
            Console.WriteLine("Welcome User.");
            Console.Write("Enter your Name: ");
            String name = Console.ReadLine();
            
            Console.Write("Enter the total number of your enrolled courses: ");
            int course = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            double fbook = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your gender?\n Choose between the choices: \n F for female       M for Male  ");
            String gender = Console.ReadLine().ToUpper();

            
            // if else statement to choose between female or male.
            if (gender == "F")
            {
                //print out the User input to show the user.
                Console.WriteLine("name: " + name +
                                   "\nGender: Female " +
                                  "\nTotal enrolled courses: " + course +
                                  "\nPrice of my favorite book: " + fbook
                                  );
            }
            else if (gender == "M")
            {
                //print out the User input to show the user.
                Console.WriteLine("name: " + name +
                                   "\nGender: Male " +
                                  "\nTotal enrolled courses: " + course +
                                  "\nPrice of my favorite book: " + fbook
                                  );
            }
            //incase user didn't choose between the choices.
            else
            {
                Console.WriteLine("Your input is Invalid.");
            }


            //to stop the terminal from automatically exiting after completion.
           Console.ReadLine();


        }
    }
}
