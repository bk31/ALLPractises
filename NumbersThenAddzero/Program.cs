namespace NumbersThenAddzero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = { 0, 0, 01, 2, 3, 4, 5, 6, 7, 8, 0, 0, 0, 0, 0, 0, };
            List<int> list = new List<int>();
            int countZero = 0;
            for (int i = 0; i < aa.Length; i++)
            {
                if (aa[i] > 0)
                {
                    list.Add(aa[i]);
                }
                else
                {
                    countZero++;
                }
            }
            for (int i = 0; i <= countZero; i++)
            {
                list.Add(0);
            }
            foreach (var item in list)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();
        }
    }
}
