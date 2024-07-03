using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_repeated_digits_in_a_given_number
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numver");
            long n = Int64.Parse(Console.ReadLine());

            // Store first digits as previous
            // digit
            long previous_digit = n % 10;
            // Initialize power
            long pow = 10;
            long result = previous_digit;
            // Iterate through all digits of n,
            // note that the digits are 
            // processed from least significant
            // digit to most significant digit.
            while (n > 0)
            {
                // Store current digit
                long curr_digit = n % 10;
                if (curr_digit != previous_digit)
                {
                    // Add the current digit to
                    // the beginning of result
                    result += curr_digit * pow;

                    // Update previous result
                    // and power
                    previous_digit = curr_digit;
                    pow *= 10;
                }
                // Remove last digit from n
                n = n / 10;
            }
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }
    }
}
