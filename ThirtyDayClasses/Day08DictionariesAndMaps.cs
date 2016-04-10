using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankChallengeCode
{
    public class Day08DictionariesAndMaps
    {

        //Submitted Code
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    int numberEntries = int.Parse(Console.ReadLine());
        //    Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        //    for (int entry = 1; entry <= numberEntries; entry++)
        //    {
        //        string inputLine = Console.ReadLine();
        //        string name = inputLine.Split(' ').FirstOrDefault();
        //        string number = inputLine.Split(' ').LastOrDefault();
        //        phoneBook.Add(name, number);
        //    }

        //    string query = Console.ReadLine();

        //    while (query != null)
        //    {
        //        try
        //        {
        //            string number = phoneBook[query];
        //            Console.WriteLine(string.Format("{0}={1}", query, number));
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Not found");
        //        }
        //        query = Console.ReadLine();
        //    }
        //}
    
    public static List<string> Dictionary(List<string> testInput)
        {
            
            int numberEntries = int.Parse(testInput[0]);
            int inputLenght = testInput.Count;
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            List<String> outputList = new List<string>();
            
            for(int entry = 1; entry <= numberEntries; entry++)
            {
                string name = testInput[entry].Split(' ').FirstOrDefault();
                string number = testInput[entry].Split(' ').LastOrDefault();
                phoneBook.Add(name, number);
            }


            for(int query = numberEntries+1; query < inputLenght; query++)
            {
                string queryName = testInput[query];
                try
                {
                    string number = phoneBook[queryName];
                    outputList.Add(string.Format("{0}={1}", queryName, number));
                }
                catch
                {
                    outputList.Add("Not found");
                }                
            }

            return outputList;
        }
    }
}