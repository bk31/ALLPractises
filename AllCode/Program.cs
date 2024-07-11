namespace AllCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            //for (int i = 5; i >=1; i--)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write(" " + i);
            //    }
            //    //   Console.Write(" " + i);
            //    Console.WriteLine();
            //}
            for (int i = 0; i <=10; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(" "+ j);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
