using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDayClasses
{
    //Given abstract Book class
    public abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    //Write MyBook class
    public class MyBook : Book
    {
        int price;

        public MyBook(string t, string a, int p) : base(t, a)
        {
            price = p;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Price: {0}", price);
        }

    }

    //class Solution
    //{
    //    static void Main(String[] args)
    //    {
    //        String title = Console.ReadLine();
    //        String author = Console.ReadLine();
    //        int price = Int32.Parse(Console.ReadLine());
    //        Book new_novel = new MyBook(title, author, price);
    //        new_novel.display();
    //    }

        class Day13AbstractClasses
    {
    }
}
