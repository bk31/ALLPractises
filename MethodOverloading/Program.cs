using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            Console.WriteLine(a.M(12));
            Console.WriteLine(a.M(12,34,5));
            Console.WriteLine(a.M("Babu K",23));
            Console.WriteLine("The GC", GC.MaxGeneration);

            Console.ReadLine();


        }
    }
    public class A
    {
        public int M(int x)
        {
            return x=13;
        }
        public string M(string x, int b)
        {
            b = 19;
            return x = "dasd";
        }
        public double M(double x, double y, double c)
        {
            c = x + y;
            return c;
        }
    }
}
