using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtherChallenges
{
    public class SherlockSquares
    {
        public static List<string> CountSquares(List<String> args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            List<String> outputList = new List<string>();
            int T = int.Parse(args[0]);
             

            for (int lcv = 1; lcv <= T; lcv++)
            {

                int A = int.Parse(args[lcv].Split(' ').FirstOrDefault());
                int B = int.Parse(args[lcv].Split(' ').LastOrDefault());

                int bottom = 0, top = 0;
                int count = 0;

                for (int lcv2 = A; lcv2 <= B; lcv2++)
                {
                    double sqRoot = Math.Sqrt(lcv2);
                    if (sqRoot == Math.Floor(sqRoot))
                    {
                        bottom = (int)sqRoot;
                        break;
                    }
                }

                for (int lcv3 = B; lcv3 >= A; lcv3--)
                {
                    double sqRoot = Math.Sqrt(lcv3);
                    if (sqRoot == Math.Floor(sqRoot))
                    {
                        top = (int)sqRoot;
                        break;
                    }
                }

                count = (top == 0 && bottom == 0 ? 0 : top - bottom + 1);

                outputList.Add(count.ToString());
            }

            return outputList;
        }
    }
}
