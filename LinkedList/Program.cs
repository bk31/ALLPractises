using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a linkedlist
        // Using LinkedList class
        LinkedList<int> my_list = new LinkedList<int>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast(10);
            my_list.AddLast(20);
            my_list.AddLast(30);
            my_list.AddLast(40);
            my_list.AddLast(50);
            my_list.AddLast(60);
            
            // Initial number of elements
            Console.WriteLine("Best students of XYZ " +
                             "university initially:");
            my_list.Reverse();

            foreach (var item in my_list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
