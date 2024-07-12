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

            Console.WriteLine(" \t");

            Console.WriteLine("Enter a string!");
            string input = Console.ReadLine();
            // string str = "Abbu K";
            while (input.Length > 0)
            {
                Console.Write(input[0] + " :");
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[0] == input[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }


            //reverse of string
            Console.WriteLine(" \t");

            Console.WriteLine("Enter a string!");
            string str = Console.ReadLine();
            string rev = " ";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine(rev);

            Console.WriteLine(" \t");

            /* Non repeating characters or removing duplicate characters  in the given string */
            string inputstring = "";
            Console.WriteLine("Enter a string");
            inputstring = Console.ReadLine();
            string resultstring = string.Empty;

            for (int i = 0; i < inputstring.Length; i++)
            {
                if (!resultstring.Contains(inputstring[i]))
                {
                    resultstring += inputstring[i];
                }
                else
                {
                    Console.WriteLine("The  repeating charactres in \t" + i);

                }
            }

            Console.WriteLine("The Non repeating charactres in \t" + resultstring);


            //Tables
            Console.WriteLine("Enter a number:");
            int s = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= s; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}*{1}={2} \t", i, j, i * j);
                }
            }
            Console.ReadLine();
        }
    }
}
