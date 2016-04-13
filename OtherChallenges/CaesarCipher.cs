using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherChallenges
{
    public class CaesarCipher
    {
        public static string Encode(List<string> testInput)
        {
            int n = int.Parse(testInput[0]);
            int k = int.Parse(testInput[2]);
            string s = testInput[1];
            string encodedString = "";

            k = k % 26;

            foreach(var chr in s)
            {
                int chrIndex = Convert.ToInt16(chr) + k;

                if ('a' <= chr && chr <= 'z')
                {
                    encodedString += (chrIndex <= 122 ? Convert.ToChar(chrIndex) : Convert.ToChar(chrIndex-26));
                }
                else if ('A' <= chr && chr <= 'Z')
                {
                    encodedString += (chrIndex <= 90 ? Convert.ToChar(chrIndex) : Convert.ToChar(chrIndex - 26));
                }
                else
                {
                    encodedString += chr;
                }
                
            }

            return encodedString;


        }
    }
}
