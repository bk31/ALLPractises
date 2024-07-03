using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            AA aA = new AA();
            AA bA = new AA(12);   
            AA cA = new AA(123,1234);
            Console.ReadLine();
        }
    }
    public class AA
    {
        public int x=123;
        public int y=1244;
        public AA()
        {
            Console.WriteLine("Concrete class called");
        }
        static AA()
        {
            Console.WriteLine("static constuctor called");

        }
        public AA(int x)
        {
            x = 1234;
            Console.WriteLine("The paramter con called:\t " + x);
        }
        private AA(string name)
        {
            Console.WriteLine("Babu K",name);
        }
        public AA(int a, int b)
        {
           x=a; y=b;
           Console.WriteLine("Copy Con called",a,b);

        }

    }
}
