﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Day18QueuesAndStacks
    {
        Stack<char> stack;
        Queue<char> queue;

        Day18QueuesAndStacks()
        {
            stack = new Stack<char>();
            queue = new Queue<char>();
        }

        char dequeueCharacter()
        {
            return queue.Dequeue();
        }

        char popCharacter()
        {
            return stack.Pop();
        }

        void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
        }

        void pushCharacter(char c)
        {
            stack.Push(c);
        }


        public static void RunPalindromeProgram()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Day18QueuesAndStacks obj = new Day18QueuesAndStacks();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }

        
    }
}
