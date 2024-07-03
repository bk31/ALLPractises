using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeOfNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ss = { 4, 3, 2, 1, 0 };
            for (int i = ss.Length - 1; i >= 0; i--)
            {
                string reversenm = "";
                reversenm += ss[i].ToString();
                Console.WriteLine($"revserse:{reversenm}");
            }

            A a = new A();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
    public static class ExtenionMethods
    {
        public static string Method(this string Name)
        {
            return Name = "Bab K";
        }
    }
    public class A
    {
        public delegate int M1(int x, int b);
        public int M11(int x, int b);
        {
        }
    }
}
