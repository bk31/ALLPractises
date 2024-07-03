namespace Create_an_application_that_accepts_a_date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accept input for date and days to add
            Console.WriteLine("Enter a date in dd/mm/yyyy format:");
            string inputDate = Console.ReadLine();

            Console.WriteLine("Enter number of days to add:");
            int daysToAdd = int.Parse(Console.ReadLine());

            // Parse the input date
            if (!DateTime.TryParseExact(inputDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine("Invalid date format. Please use dd/mm/yyyy format.");
                return;
            }

            // Add days to the date using custom function
            DateTime newDate = AddDaysToDate(date, daysToAdd);

            // Output the resulting date
            Console.WriteLine($"Resulting date after adding {daysToAdd} days: {newDate:dd/MM/yyyy}");
        }

        // Custom function to add days to a date without using built-in date functions
        static DateTime AddDaysToDate(DateTime date, int daysToAdd)
        {
            // Start adding days
            int daysToAddRemaining = daysToAdd;
            int daysInMonth;

            while (daysToAddRemaining > 0)
            {
                // Days remaining in the current month
                daysInMonth = DateTime.DaysInMonth(date.Year, date.Month) - date.Day + 1;

                if (daysToAddRemaining < daysInMonth)
                {
                    // If we can add all remaining days in the current month
                    date = date.AddDays(daysToAddRemaining);
                    daysToAddRemaining = 0; // No more days to add
                }
                else
                {
                    // Add all remaining days in the current month
                    date = date.AddDays(daysInMonth);
                    daysToAddRemaining -= daysInMonth;

                    // Move to the next month
                    date = new DateTime(date.Year, date.Month, 1).AddMonths(1);
                }
            }

            return date;
        }
    }
}
