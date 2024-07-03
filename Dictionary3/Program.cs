using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> keyValuePairs = new Dictionary<int, Employee>();
            var emp = new Employee()
            {
                Id = 1,
                Name = "babu",
                Address = "Bangalore",
                City = "BLR",
                Region = "South India"
            };
            keyValuePairs.Add(1,emp);
           foreach (KeyValuePair<int,Employee> pair in keyValuePairs)
            {
                Console.WriteLine(pair.Key+" is  "+pair.Value.Region);
            }
           Console.ReadLine();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string Region { get; set; }
    }
}
