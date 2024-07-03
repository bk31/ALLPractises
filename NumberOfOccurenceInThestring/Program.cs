namespace NumberOfOccurenceInThestring
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a string!");
            string s = Console.ReadLine();
            //string result=string.Empty;

            while (s.Length > 0)
            {

                Console.Write(s[0] + " : ");
                int count = 0;

                for (int j = 0; j < s.Length; j++)
                {

                    if (s[0] == s[j])

                    {

                        count++;

                    }

                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(), string.Empty);
            }

            Console.WriteLine("The number of occurance of a given string is \t" + s);
            Console.ReadLine();
        }
    }
}
