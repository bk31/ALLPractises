using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                if (i % num == 0)
                {
                    Console.WriteLine("Prime numbers are :" + num);
                }
                else
                {
                    Console.WriteLine("Not prime" + num);
                }
            }
            Console.ReadLine();
        }
    }
}
