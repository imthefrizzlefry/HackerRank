using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Day02Operators
    {
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    double mealCost, tipPercent, taxPercent;
        //    double totalCost;

        //    mealCost = double.Parse(Console.ReadLine());
        //    tipPercent = double.Parse(Console.ReadLine());
        //    taxPercent = double.Parse(Console.ReadLine());

        //    double tip = (mealCost * (tipPercent / 100));
        //    double tax = (mealCost * (taxPercent / 100));

        //    totalCost = mealCost + tip + tax;
        //    totalCost = Math.Round(totalCost);

        //    Console.WriteLine(string.Format("The total meal cost is {0} dollars.", totalCost));

        //}

        public static string MealTotal(List<String> mealCosts)
        {
            double mealCost, tipPercent, taxPercent;
            double totalCost;

            mealCost = double.Parse(mealCosts[0]);
            tipPercent = double.Parse(mealCosts[1]);
            taxPercent = double.Parse(mealCosts[2]);

            double tip = (mealCost * (tipPercent / 100));
            double tax = (mealCost * (taxPercent / 100));

            totalCost = mealCost + tip + tax;
            totalCost = Math.Round(totalCost);

            return string.Format("The total meal cost is {0} dollars.", totalCost);

        }

    }
}
