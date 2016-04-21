using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{

    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here
        public Difference(int[] el)
        {
            this.elements = el;
        }

        public void computeDifference()
        {
            this.maximumDifference = elements.Max() - elements.Min();
        }

    } // End of Difference Class



    //class Solution
    //{
    //    static void Main(string[] args)
    //    {
    //        Convert.ToInt32(Console.ReadLine());

    //        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

    //        Difference d = new Difference(a);

    //        d.computeDifference();

    //        Console.Write(d.maximumDifference);
    //    }
    //}
    class Day14Scope
    {
    }
}
