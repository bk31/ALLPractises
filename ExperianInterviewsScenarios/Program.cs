namespace ExperianInterviewsScenarios
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Enter the total amount of money given in pence (e.g., 500 for £5.00):");
            int totalMoney = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the purchase price of the product in pence:");
            int purchasePrice = int.Parse(Console.ReadLine());

            // Calculate the change
            int change = totalMoney - purchasePrice;

            // Output the change breakdown
            Console.WriteLine("\nChange to be returned:");

            int[] denominations = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            string[] denominationNames = new string[] { "£2", "£1", "50p", "20p", "10p", "5p", "2p", "1p" };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = change / denominations[i];
                change %= denominations[i];

                if (count > 0)
                {
                    Console.WriteLine($"{count} x {denominationNames[i]}");
                }
            }

            Console.ReadLine(); // Pause to see output (for console app)
        }
    }
}
