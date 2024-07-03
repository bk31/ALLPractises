using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mergetwosortedarrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 0, 6, 73, 23, 16 };
            int[] ar1 = { 1, 3, 5, 0, 6, 73, 23, 90 };

            int temp=0;
            for (int i = 0; i < arr.Length; i++) 
            {
               for(int j=i+1; j< arr.Length; j++)
                {
                    temp= arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();

        }
    }
}
