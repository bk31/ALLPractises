using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public class Program
    {
        static void Main(string[] args)
        {
            int f, f1 = 0, f2 = 1;
            for (int i = 2; i <10; i++)
            {
                f = f1 + f2;
                Console.Write(f + " ");
                f1 = f2;
                f2= f;
               
            }
            Console.ReadLine();
        }
    }
}
