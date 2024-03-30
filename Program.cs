using System;
using System.Collections;
using System.Collections.Generic;

namespace CIT_190_Lesson_7_Collections_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> bookTitles = new LinkedList<string>();

            bookTitles.AddFirst("The Positronic Man");
            bookTitles.AddFirst("The Caves of Steel");
            bookTitles.AddFirst("The Naked Sun");
            bookTitles.AddFirst("The Robots of Dawn");
            bookTitles.AddFirst("Pebble in the Sky");

            Console.WriteLine("Once again, we have a list of Isaac Asimov books!");
            Console.WriteLine();
            foreach (string b in bookTitles)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();
            Console.WriteLine("The first book in the list is " + bookTitles.First());
            Console.WriteLine("The last book in the list is " + bookTitles.Last());

            Console.WriteLine();
            Console.WriteLine("Did he write more than " + bookTitles.Count() + " books?  Yes!");
            Console.WriteLine("Let's add 'The Currents of Space' into the middle of the list.");
            Console.WriteLine("So that'll be just before 'The Naked Sun'.");
            Console.WriteLine();

            LinkedListNode<string> targetLocation = bookTitles.Find("The Naked Sun");
            bookTitles.AddBefore(targetLocation, "The Currents of Space");

            foreach (string b in bookTitles)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine() ;
            Console.WriteLine("In fact, let's get rid of 'The Naked Sun'.") ;
            bookTitles.Remove("The Naked Sun");
            Console.WriteLine();

            foreach (string b in bookTitles)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine();
            Console.WriteLine("Now we're back to " + bookTitles.Count() + " titles!");
        }
    }
}
