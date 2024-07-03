using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1,0,2,0,3,0,0,4,5,0


            int[] arry = { 1, 0, 2, 0, 3, 0, 0, 4, 5, 0 };


            List<int> list = new List<int>();

            foreach (int item in arry)
            {
                if (item != 0)
                {
                    list.Add(item);
                }
            }
            foreach (int item in arry)
            {
                if (item == 0)
                {
                    list.Add(item);
                }
            }

            var ss = list.ToArray();
            foreach (var num in ss)
            {
                Console.Write(num);
            }
            Console.ReadLine();
        }
    }
}
