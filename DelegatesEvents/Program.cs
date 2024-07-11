namespace DelegatesEvents
{
    public delegate int DelEventHandler(int a, int b);
    public class Program
    {
        public static event DelEventHandler Add;
        static void Main(string[] args)
        {
            Add += new DelEventHandler(Add1);
            Add += new DelEventHandler(Mull);
            Add += new DelEventHandler(Sub);
            Add.Invoke(12,12);
            // Console.WriteLine(" "+Add);
            Console.ReadLine();
        }
        static int Add1(int a, int b)
        {
            Console.WriteLine($" {a + b}");

            return a + b;
        }
        static int Mull(int a, int b)
        {
            Console.WriteLine($" {a * b}");

            return a * b;
        }
        static int Sub(int a, int b)
        {
            Console.WriteLine($" {a - b}");

            return a - b;
        }
    }
}
