namespace RepeatedNumberInArrayandPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 2, 3, 5, 6, 7, 8, 9, 11, 21, 11, 10, 9 };
            int[] num2 = new int[30];
            for (int i = 0; i < num.Length; i++)
            {
                if (num2[num[i]] == 0)
                {
                    num2[num[i]] = 1;
                }
                else
                {
                    num2[num[i]]++;
                    Console.Write(" \t" + num2[num[i]]);

                    //Console.WriteLine(" The values are " + num2[num[i]] + "The position is" + i);
                }
            }
            Console.ReadLine();
        }
    }
}
