using System.Collections;

namespace Sort_an_array_in_ascending_order_without_using_inbuilt
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 1, 2, 3, 4, 190, 5, 6, 112, 7, 8, 9, 10, 11, 12, 13, 14, };
            int temp = 0;
            //for (int i = 0; i <= arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < args.Length; j++)
            //{
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            Console.WriteLine("\t\n");
            foreach (int item in arr)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();
        }
    }
}
