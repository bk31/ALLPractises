namespace NumberOfOccuranceOfAString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string ");
            string input = Console.ReadLine();
            while (input.Length > 0)
            {
                Console.Write(input[0] + " : ");

                int count = 0;

                for (int j = 0; j < input.Length; j++)

                {

                    if (input[0] == input[j])

                    {

                        count++;

                    }

                }

                Console.WriteLine(count);

                input = input.Replace(input[0].ToString(), string.Empty);
            }
            Console.WriteLine("\t\n");

            Console.WriteLine("Palindrome\t\t");

            Console.WriteLine("Enter a numbers");

            string s = Console.ReadLine();
            string rev = string.Empty;
            for (int j = s.Length - 1; j >= 0; j--)
            {
                rev += s[j].ToString();
            }
            Console.WriteLine($"revsese string is\t {rev} \t");

            if (rev == s)
            {
                Console.WriteLine($"{rev} \t Palindrome");
            }
            else
            {
                Console.WriteLine($"{rev} \t Not a Palindrom");
            }


            Console.WriteLine("\t\n");
            Console.WriteLine("Reverse of number using number\t\t");

            Console.WriteLine("Enter a number");
            int numberss = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (numberss > 0)
            {
                int reminder;
                reminder = numberss % 10;
                numberss = numberss / 10;
                reverse = (reverse * 10) + reminder;
                
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", numberss);
            if (numberss == reverse)
            {
                Console.WriteLine($" Palidrome {0} ", numberss);
            }
            Console.WriteLine($" number is reveersed {reverse} ");




            int num, rem, sum = 0, temp;
            //clrscr();    
            Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
            Console.Write("\n Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10; //for getting remainder by dividing with 10    
                num = num / 10; //for getting quotient by dividing with 10    
                sum = sum * 10 + rem;
                /*multiplying the sum with 10 and adding  
                remainder*/
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
                Console.ReadLine();
            }


            //clrscr();    
            Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
            Console.Write("\n Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
    }
}
