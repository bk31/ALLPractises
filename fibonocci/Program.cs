namespace fibonocci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0, f1 = 1, f2;
            Console.WriteLine("Enter a num");
            int num = int.Parse(Console.ReadLine());
            for (int i = 3; i < num; i++)
            {
                f2 = f + f1;
                Console.WriteLine($"{f2}");
                f = f1;
                f1 = f2;

            }
            Console.WriteLine(" n");
            Console.ReadLine();
        }
    }
}
