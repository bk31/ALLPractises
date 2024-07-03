namespace l1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 2, 3, 5, 6, 7, 8, 9, 11, 21, 11, 10, 9 };
            int[] num2 = new int[100];
            for (int i = 0; i < num.Length; i++)
            {
                if (num2[num[i]] == 0)
                {
                    num2[num[i]] = 1;
                }
                else
                {
                    num2[num[i]]++;
                    Console.WriteLine("The values are \t " + num[i] + "  The position is \t" + i);
                }
            }
            Console.ReadLine();
        }
    }
}
