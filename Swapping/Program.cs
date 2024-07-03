namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a=13,b=14;

            a = a + b; //27
            b = a - b; //27-14=13
            a = a - b; //

            Console.WriteLine($"{a} and {b}");
            Console.ReadLine();
        }
    }
}
