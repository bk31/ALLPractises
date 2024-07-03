using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp += arr[i];
            }
            Console.WriteLine(temp);



            
            Console.ReadLine();
        }


    }
}
