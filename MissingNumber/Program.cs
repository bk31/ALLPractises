using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 6, 7, 8, 9, 10, 11, };
            int missNum = 0;
            for(int i=0; i<arr.Length-1; i++)
            {
                if (arr[i] != arr[i+1]+1)
                {
                    missNum = arr[i] + 1;
                }
            }
            Console.WriteLine(missNum);
            Console.ReadLine();
        }
    }
}
