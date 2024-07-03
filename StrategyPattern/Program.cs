namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculateClient calculateClient = new CalculateClient(new Minus());
            Console.WriteLine(calculateClient.Calculate(12,23).ToString());
            CalculateClient plusClient = new CalculateClient(new Plus());
            Console.WriteLine(plusClient.Calculate(12,23).ToString());
            Console.ReadLine();


        }
    }
}
