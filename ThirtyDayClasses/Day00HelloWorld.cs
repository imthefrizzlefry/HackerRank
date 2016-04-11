using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Day00HelloWorld
    {

        //static void Main(String[] args)
        //{
        //    String inputString; // declare a variable to hold our input
        //    inputString = Console.ReadLine(); // get a line of input from stdin and save it to our variable

        //    // Your first line of output goes here
        //    Console.WriteLine("Hello, World.");

        //    // Write the second line of output
        //    Console.WriteLine(inputString);
        //}

        public static string Hello(string arg)
        {
            String inputString; // declare a variable to hold our input
            String outputString = "Hello, World.";

            inputString = arg; // get a line of input from stdin and save it to our variable

            
            // Write the second line of output
            outputString += inputString;

            return outputString;
        }
    }
}
