using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherChallenges
{
    public class CutTheSticks
    {
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] arr_temp = Console.ReadLine().Split(' ');
        //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

        //    while (n > 0)
        //    {
        //        Console.WriteLine(n);
        //        int min = arr[0];

        //        foreach (var num in arr)
        //        {
        //            min = (num <= min ? num : min);
        //        }
        //        n -= arr.Count(x => x == min);

        //        arr = arr.Where(val => val != min).ToArray();

        //    }
        //}

        public static List<string> NumberOfCuts(List<string> testInput)
        {
            List<string> returnValue = new List<string>();

            int stickCount = int.Parse(testInput[0]);
            
            List<string> strStickLengths= new List<string>(testInput[1].Split(' '));
            

            while (strStickLengths.Count() > 0)
            {

                returnValue.Add(strStickLengths.Count().ToString());
                string cut = strStickLengths.Min();
                for (int lcv = strStickLengths.Count(x => x == cut); lcv > 0; lcv--)
                {
                    strStickLengths.Remove(cut);
                }
            }
            return returnValue;

        }
    }
}
