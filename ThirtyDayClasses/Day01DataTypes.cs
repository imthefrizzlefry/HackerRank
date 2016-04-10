using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallengeCode
{
    //// Declare second integer, double, and String variables.
    //int i2;
    //double d2;
    //string myString;

    //// Read and save an integer, double, and String to your variables.
    //cin >> i2;
    //cin.ignore();
    //cin >> d2;
    //cin.ignore();
    //cin.ignore();
    //getline(std::cin, myString);

    //// Print the sum of both integer variables on a new line.
    //cout << i+i2 << endl;
    //// Print the sum of the double variables on a new line.
    //cout.precision(1);
    //cout << fixed << d + d2 << endl;
    //// Concatenate and print the String variables on a new line
    //// The 's' variable above should be printed first.
    //cout << s << myString;

    public class Day01DataTypes
    {

        //static void Main(String[] args)
        //{
        //    int i = 4;
        //    double d = 4.0;
        //    string s = "HackerRank ";
        //    // Declare second integer, double, and String variables.
        //    int i2;
        //    double d2;
        //    string s2;
        //    // Read and save an integer, double, and String to your variables.
        //    i2 = int.Parse(Console.ReadLine());
        //    d2 = double.Parse(Console.ReadLine());
        //    s2 = Console.ReadLine();

        //    // Print the sum of both integer variables on a new line.
        //    Console.WriteLine(i + i2);

        //    // Print the sum of the double variables on a new line.
        //     Console.WriteLine(String.Format("{0:F1}",d + d2));

        //    // Concatenate and print the String variables on a new line
        //    // The 's' variable above should be printed first.
        //    Console.WriteLine(s + s2);  
        //}


        public static List<String> DataTypes(List<String> args)
        {
            //Given these three lines:
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            List<String> outputList = new List<string>();

            // Declare second integer, double, and String variables.
            int i2;
            double d2;
            string s2;

            // Read and save an integer, double, and String to your variables.
            i2 = int.Parse(args[0]);
            d2 = double.Parse(args[1]);
            s2 = args[2];

            // Print the sum of both integer variables on a new line.
            outputList.Add((i + i2).ToString());

            // Print the sum of the double variables on a new line.
            outputList.Add(String.Format("{0:F1}", d + d2));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            outputList.Add(s + s2);

            return outputList;
        }
    }
}
