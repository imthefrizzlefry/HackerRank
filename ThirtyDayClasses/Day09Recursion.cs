using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Day09Recursion
    {

        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //    int inputValue = int.Parse(Console.ReadLine());

        //    int result = factorial(inputValue);

        //    Console.WriteLine(result);
        //}

        public static int factorial(int fact)
        {
            return (fact > 1 ? fact * factorial(fact - 1) : fact);
        }
    }
}
