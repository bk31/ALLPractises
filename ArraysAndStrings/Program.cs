using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 6, 3, 7, 8 };
            int missNumber = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != array[i+1]-1)
                {
                    missNumber = array[i] + 1;
                }
            }
            Console.WriteLine(missNumber);
            Console.ReadLine();
        }
    }
}
