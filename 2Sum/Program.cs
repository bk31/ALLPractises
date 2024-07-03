namespace _2Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Target Value :");

            int targetElement = Int32.Parse(Console.ReadLine());
            int[] twosum = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,15 };

            for (int i = 0; i < twosum.Length; i++)
            {
                for (int j = i + 1; j < twosum.Length; j++)
                {
                    if (targetElement == twosum[j] + twosum[i])
                    {
                        Console.WriteLine($"The pair of elements  for two Sum are {twosum[i]} and {twosum[j]} ===>{targetElement}");
                    }
                   


                }
            }
            Console.ReadLine();
        }
    }
}
