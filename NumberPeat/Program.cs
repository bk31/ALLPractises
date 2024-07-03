namespace NumberPeat
{
    public class Program
    {
        static void Main(string[] args)
        {

            CalculateClient minusClient = new CalculateClient(new Minus());
            Console.Write("Minus: " + minusClient.Calculate(7, 1).ToString());

            Console.ReadLine();
        }
    }
    // // Define an interface with multiple methods
    // interface IExampleInterface
    // {
    //     void Method1();
    //     void Method2();
    //     void Method3();
    // }
    // // Implement the interface partially in a subclass
    //abstract class SubClass : IExampleInterface
    // {
    //     // Implement only Method2
    //     public void Method2()
    //     {
    //         Console.WriteLine("Method 2 called from SubClass");
    //     }

    //     // Method1 and Method3 are not implemented in this subclass
    // }
    public sealed class Singleton
    {
        private readonly static Singleton singleton = new Singleton();

        private Singleton()
        {

        }
        static Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return singleton;
            }
        }

    }
    public interface ICalculateInterface
    {
        //define method  
        int Calculate(int value1, int value2);
    }
    class Minus : ICalculateInterface
    {
        public int Calculate(int value1, int value2)
        {
            //define logic  
            return value1 - value2;
        }
    }
    class CalculateClient
    {
        private ICalculateInterface calculateInterface;

        //Constructor: assigns strategy to interface  
        public CalculateClient(ICalculateInterface strategy)
        {
            calculateInterface = strategy;
        }

        //Executes the strategy  
        public int Calculate(int value1, int value2)
        {
            return calculateInterface.Calculate(value1, value2);
        }
    }
}
