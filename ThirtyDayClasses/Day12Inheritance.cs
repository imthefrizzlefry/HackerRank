using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{

    //class Solution
    //{
    //    static void Main()
    //    {
    //        string[] inputs = Console.ReadLine().Split();
    //        string firstName = inputs[0];
    //        string lastName = inputs[1];
    //        int id = Convert.ToInt32(inputs[2]);
    //        int numScores = Convert.ToInt32(Console.ReadLine());
    //        inputs = Console.ReadLine().Split();
    //        int[] scores = new int[numScores];
    //        for (int i = 0; i < numScores; i++)
    //        {
    //            scores[i] = Convert.ToInt32(inputs[i]);
    //        }

    //        Student s = new Student(firstName, lastName, id, scores);
    //        s.printPerson();
    //        Console.WriteLine("Grade: " + s.calculate() + "\n");
    //    }
    //}

        //Class Given by the challenge
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    //only implemented constructor, calculate for challenge
    // create getStudentData for my own tests
    public class Student : Person
    {
        private int[] testScores;
        public Student(string firstName, string lastName, int identification, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
            this.testScores = scores;
        }

        public char calculate()
        {
            int average = 0;
            int count = 0;

            foreach (var score in this.testScores)
            {
                average += score;
                count++;
            }

            average = average / count;

            char letterScore;

            if (average >= 90)
            {
                letterScore = 'O';
            }
            else if (average >= 80)
            {
                letterScore = 'E';
            }
            else if (average >= 70)
            {
                letterScore = 'A';
            }
            else if (average >= 55)
            {
                letterScore = 'P';
            }
            else if (average >= 40)
            {
                letterScore = 'D';
            }
            else
            {
                letterScore = 'T';
            }

            return letterScore;
        }

        public List<string> getStudentData()
        {
            return new List<string>
            {
                string.Format("Name: {0}, {1}", this.lastName, this.firstName),
                string.Format("ID: {0}", this.id),
                string.Format("Grade: {0}", calculate())
            };

        }
    }

    class Day12Inheritance
    {
    }
}
