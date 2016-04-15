using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Day07Arrays
    {
        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine()) - 1;
        //    string[] arr_temp = Console.ReadLine().Split(' ');
        //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        //    string returnValue = "";
        //    int swapEnd = n;

        //    for (int swapStart = 0; swapStart < swapEnd; swapStart++)
        //    {
        //        SwapInt(ref arr[swapStart], ref arr[swapEnd]);
        //        swapEnd--;
        //    }

        //    foreach (int num in arr)
        //    {
        //        returnValue += (num == arr[n] ?
        //                            num.ToString() :
        //                            (num.ToString() + " "));

        //    }

        //    Console.WriteLine(returnValue);
        //}

        private static void SwapChars(ref char x, ref char y)
        {
            x = (char)(x ^ y);
            y = (char)(y ^ x);
            x = (char)(x ^ y);
        }

        private static void SwapInt(ref int x, ref int y)
        {
            x = x ^ y;
            y = y ^ x;
            x = x ^ y;
        }

        public static string ReverseArray(List<string> testInput)
        {
            int n = Convert.ToInt32(testInput[0])-1;
            string[] arr_temp = testInput[1].Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            string returnValue = "";

            int swapEnd = n;
            for(int swapStart = 0; swapStart < swapEnd; swapStart++)
            {
                SwapInt(ref arr[swapStart], ref arr[swapEnd]);
                swapEnd--;
            }

            foreach (int num in arr)
            {
                returnValue += (num == arr[n] ? 
                                    num.ToString() : 
                                    (num.ToString() + " ") );
                
            }

            return returnValue;
        }
    }
}
