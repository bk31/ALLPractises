using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camelcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "ILovegeeksForGeeks";
            getOrgString(s);
            Console.ReadLine();
        }
        // Function to return the original string 
        // after converting it back from camelCase 
        static void getOrgString(String s)
        {

            // Print the first character as it is 
            Console.Write(s[0]);

            // Traverse the rest of the 
            // characters one by one 
            int i = 1;
            while (i < s.Length)
            {

                // If current character is uppercase 
                // print space followed by the 
                // current character in lowercase 
                if (s[i] >= 'A' && s[i] <= 'Z')
                    Console.Write(" " + char.ToUpper(s[i]));

                // Else print the current character 
                else
                    Console.Write(s[i]);

                i++;
            }
        }
    }
}
