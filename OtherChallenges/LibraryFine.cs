using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherChallenges
{
    public class LibraryFine
    {
        public static string CalculateLateFee(List<string> testInput)
        {
            string[] tokens_d1 = testInput[0].Split(' ');
            int d1 = Convert.ToInt32(tokens_d1[0]);
            int m1 = Convert.ToInt32(tokens_d1[1]);
            int y1 = Convert.ToInt32(tokens_d1[2]);
            string[] tokens_d2 = testInput[1].Split(' ');
            int d2 = Convert.ToInt32(tokens_d2[0]);
            int m2 = Convert.ToInt32(tokens_d2[1]);
            int y2 = Convert.ToInt32(tokens_d2[2]);

            int lateFee = 0;

            if (y1 == y2)
            {
                if (m1 == m2)
                {
                    if (d1 > d2)
                    {
                        lateFee = (d1 - d2) * 15;
                    }
                    
                }
                else if(m1 > m2)
                {
                    lateFee = (m1 - m2) * 500;
                }
            }
            else if (y1 > y2)
            {
                lateFee = 10000;
            }
                        

            return lateFee.ToString();
        }
        
    }
}