using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_number
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string num=Convert.ToString(Console.ReadLine());

            string rev = "";
            for (int i=num.Length-1;i>=0;i--)
            {
                rev += num[i];
            }
            if(rev==num)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palidrome");
            }



            Console.ReadLine();
        }
    }
}
