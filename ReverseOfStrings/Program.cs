namespace ReverseOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];

            }
            Console.WriteLine(" " + rev);

            Console.WriteLine("END==============>");
            if(rev == str)
            {
                Console.WriteLine($"Palindrome of a string is {rev}");
            }
            else
            {
                Console.WriteLine($"Not a Palindrome of a string is {rev}");
                
            }
            Console.ReadLine();

        }
    }
}
