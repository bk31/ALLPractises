using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s, rev = "";
            
            Console.WriteLine("Enter a string:");
            s = Console.ReadLine();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();

            }
            Console.WriteLine("Th Reverse of a string: "+rev);

            if(rev==s)
            {
                Console.WriteLine("The given string is palindrom");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
            Something();
            Console.WriteLine(result);

            Console.ReadLine();

        }

        public static string result;
        public static string tt;
        public static async Task<string> Something()
        {
            await  Task.Delay(5);
            result = "Somethings";
            return "Hi Babu K";
        }
    }
}
