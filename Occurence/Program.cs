namespace Occurence
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());

            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine($"{reverse}");

            Console.WriteLine("\t\n");

            if (reverse == number)
            {
                Console.WriteLine($"Palindrome of a number{reverse}");
            }
            else
            {
                Console.WriteLine("Not a palidrome ");
            }
            Console.WriteLine("\t\n");


            /*=========================*/
            Console.Write("Enter a string : ");
            string name = Console.ReadLine();
            string rev = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                rev += name[i].ToString();
            }
            Console.WriteLine($"The reverse string is : {rev}");
            Console.WriteLine("\t\n");

            if (rev == name)
            {

                Console.WriteLine($" Palindrome of a string : {rev}");

            }
            else
            {
                Console.WriteLine("Not a palidrome ");

            }
            Console.ReadLine();
        }


    }
}
