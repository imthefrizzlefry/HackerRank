using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Day16ExceptionsStringToInteger
    {
        public static void CatchParsingException()
        {
            string S = Console.ReadLine();
            try
            {
                int testValue = int.Parse(S);
                Console.Write(testValue);
            }
            catch
            {
                Console.Write("Bad String");
            }
        }
    }
}
