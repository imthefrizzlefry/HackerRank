﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    public class Day15LinkedList
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
            {
                head = new Node(data);
                return head;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data);
            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        //static void Main(String[] args)
        //{

        //    Node head = null;
        //    int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0)
        //    {
        //        int data = Int32.Parse(Console.ReadLine());
        //        head = insert(head, data);
        //    }
        //    display(head);
        //}

    }
}
