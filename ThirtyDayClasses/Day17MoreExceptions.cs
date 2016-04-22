using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Calculator
    {
        public int power(int n, int p)
        {
            if(n < 0 || p < 0 )
            {
                Exception e = new Exception("n and p should be non-negative");
                throw e;
            }
            else
            {
                return (int)Math.Pow((double)n, (double)p);
            }            
        }
    }

    public class Day17MoreExceptions
    {
        public static void RunMoreExceptions()
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }



        }
    }
}
