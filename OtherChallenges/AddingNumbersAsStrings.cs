using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherChallenges
{
    public class AddingNumbersAsStrings
    {
        // a, b
        // limit of in, long, BigInteger
        // signed and unsigned - set to positive only
        // whole and fractions - set to integers only
        // charicter limits of client - 500 char limit
        // non-numeric chars
        // random input - generator 500,000
        // some expected errors
        // performance - takes less than 100ms
        // platform restrictions - server side
        // basic addition
        // carry larger additions (6+6) (4+8)
        //68 + 76
        // if limit 5char -> 99999+2 999999+2 2+999999

        //a = 123 -> lenght = 3
        //b = 23 -> lenght = 2

        //a = 129
        //b = 139

        public static string StringAdder(string a, string b)
        {

            //declare a return value
            StringBuilder result = new StringBuilder();

            //normalize values for a and b (so they are both the same size
            int maxLength = Math.Max(a.Length, b.Length);
            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');

            
            bool carryDigit = false;

            
            // check for invalid characters

            //loop through each char in a a.length -> a[0]
            for (int bIndex = maxLength - 1; bIndex >= 0; bIndex--)
            {
                // force 
                int sum = carryDigit ? 1 : 0;
                
                sum += AddChars(a[bIndex], b[bIndex]);
                

                if(sum >= 10)
                {
                    result.Insert(0, sum % 10);
                    carryDigit = true;
                }
                else
                {
                    result.Insert(0, sum);
                    carryDigit = false;
                }

                if(bIndex == 0 && carryDigit)
                {
                    result.Insert(0, 1);
                }
                                
            }

            return result.ToString();
        }

        private static int AddChars(char a, char b)
        {
            int aSubX = Convert.ToInt32(a) - 48;
            int bSubX = Convert.ToInt32(b) - 48;
            return aSubX + bSubX;            
        }
        
    }
}
