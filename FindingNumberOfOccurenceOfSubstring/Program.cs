namespace FindingNumberOfOccurenceOfSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");

            string str = Console.ReadLine();
            int s = 0;
            s = str.Split("ab").Length - 1;
            Console.WriteLine(" " + s);
            Console.ReadLine();

        }
    }
}
