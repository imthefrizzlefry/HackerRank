using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace OtherChallenges
{
    public class FibModified
    {
        public static string Calculate(string testInput)
        {
            int a = int.Parse(testInput.Split(' ')[0]);
            int b = int.Parse(testInput.Split(' ')[1]);
            int n = int.Parse(testInput.Split(' ')[2]);

            BigInteger a1 = new BigInteger(a);
            BigInteger b1 = new BigInteger(b);

            for (int lcv = 2; lcv <= n;lcv++)
            {
                BigInteger temp = BigInteger.Pow(b1, 2) + a1;
                a1 = b1;
                b1 = temp;
            }

            return a1.ToString();
        }
    }
}
