namespace Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8,12000 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The Array sume is : \t" + sum);
            Console.ReadLine();
        }
    }
}
