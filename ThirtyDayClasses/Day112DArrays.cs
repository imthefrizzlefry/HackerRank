using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Day112DArrays
    {
        //static void Main(String[] args)
        //{
        //    int[][] arr = new int[6][];
        //    int[][] aHourGlasses = new int[4][];
        //    int[] largest = new int[2] { 0, 0 };

        //    for (int arr_i = 0; arr_i < 6; arr_i++)
        //    {
        //        string[] arr_temp = Console.ReadLine().Split(' ');
        //        arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        //    }

        //    //find the largest HourGlass
        //    for (int yIndex = 0; yIndex < 4; yIndex++)
        //    {
        //        if (aHourGlasses[yIndex] == null)
        //        {
        //            aHourGlasses[yIndex] = new int[4];
        //        }
        //        for (int xIndex = 0; xIndex < 4; xIndex++)
        //        {
        //            //generate a sum of 3x3 array starting from xIndex,yIndex                    
        //            aHourGlasses[yIndex][xIndex] = arr[yIndex][xIndex] + arr[yIndex][xIndex + 1] + arr[yIndex][xIndex + 2] +
        //                arr[yIndex + 1][xIndex + 1] +
        //                arr[yIndex + 2][xIndex] + arr[yIndex + 2][xIndex + 1] + arr[yIndex + 2][xIndex + 2];
        //            int[] temp = new int[] { yIndex, xIndex };
        //            largest = (aHourGlasses[temp[0]][temp[1]] >= aHourGlasses[largest[0]][largest[1]] ? temp : largest);
        //        }
        //    }

        //    Console.WriteLine(aHourGlasses[largest[0]][largest[1]]);
        //}

        public static string LargestHourGlass(List<string> testInput)
        {
            int[][] arr = new int[6][];
            
            int[][] aHourGlasses = new int[4][];
            int[] largest = new int[2] { 0, 0 };
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = testInput[arr_i].Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            //find the largest HourGlass
            for(int yIndex = 0; yIndex < 4; yIndex++)
            {
                if(aHourGlasses[yIndex] == null)
                {
                    aHourGlasses[yIndex] = new int[4];
                }
                for (int xIndex = 0; xIndex < 4; xIndex++)
                {
                    //generate a sum of 3x3 array starting from xIndex,yIndex                    
                    aHourGlasses[yIndex][xIndex] = arr[yIndex][xIndex] + arr[yIndex][xIndex + 1] + arr[yIndex][xIndex + 2] +
                                                                           arr[yIndex + 1][xIndex + 1] + 
                                                   arr[yIndex + 2][xIndex] + arr[yIndex + 2][xIndex + 1] + arr[yIndex + 2][xIndex + 2];
                    int[] temp = new int[] { yIndex, xIndex };
                    largest = (aHourGlasses[temp[0]][temp[1]] >= aHourGlasses[largest[0]][largest[1]] ? temp : largest);
                }
            }

            return aHourGlasses[largest[0]][largest[1]].ToString(); 
        }
    }
}
