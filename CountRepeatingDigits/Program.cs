using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRepeatingDigits
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number");
            int repeatinpit = Int32.Parse(Console.ReadLine());
            string s = repeatinpit.ToString();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++; // Increment count if a repeating digit is found
                        break; // Exit the inner loop once a repeating digit is found
                    }
                }
            }
            Console.WriteLine($"The count of given {s} is  :{count} ");
            Console.ReadLine();
        }
    }
}
