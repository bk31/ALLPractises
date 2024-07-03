namespace RepeatingNumberANDItsPositions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter A Value for an array");
           // string arr = Console.ReadLine();
            
            int[] aa = {1,2,34,5,6,2,3,5,8,10,11,12};
            RepeatNumber repeatNumber = new RepeatNumber();

            repeatNumber.RepeatNumberPosition(aa);
        }
    }

    public class RepeatNumber
    {
        public int RepeatNumberPosition(int[] num)
        {
            int[] secondNum = new int[100];
            for (int i = 0; i < num.Length; i++)
            {
                if (secondNum[num[i]] == 0)
                {
                    secondNum[num[i]] = 1;
                }
                else
                {
                    secondNum[num[i]]++;
                    Console.WriteLine($"The value is =====> " + num[i] + "===========>Position at" + i);

                }
            }
            return 0;
        }
    }
}
