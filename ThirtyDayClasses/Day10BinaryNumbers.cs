using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Day10BinaryNumbers
    {
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int consecCount = 0;
        //    int maxConsec = 0;
        //    bool prev = false;
        //    while (n > 0)
        //    {
        //        int mod = n % 2;

        //        consecCount = (prev ? consecCount + mod : mod);
        //        prev = (mod > 0 ? true : false);
        //        maxConsec = (consecCount > maxConsec ? consecCount : maxConsec);

        //        n = n >> 1;
        //    }

        //    Console.WriteLine(maxConsec);
        //}

        public static string ConsecutiveOnes(string testInput)
        {
            int value = int.Parse(testInput);
            int consecCount = 0;
            int maxConsec = 0;
            bool prev = false;
            while(value > 0)
            {
                int mod = value % 2;

                consecCount = (prev ? consecCount + mod : mod);
                prev = (mod > 0 ? true : false);
                maxConsec = (consecCount > maxConsec ? consecCount : maxConsec);

                value = value >> 1;
            }

            
            return maxConsec.ToString();
        }
    }
}
