using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_non_repeating_character_in_astring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("enter a string:");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i], s.IndexOf(s[i]) + 1)== -1)
                {
                    Console.WriteLine("Non repeatitive in the given string:" + s[i]);
                }
            }
            A.Mq(12, 34);
            Console.ReadLine(); 
        }
    }
    public class A
    {
        public  int x;
        public  int y;
        public static int Mq(int a, int b)
        {
            int c=a+b;
            Console.WriteLine(c);
            return c;
        }
    }
}
