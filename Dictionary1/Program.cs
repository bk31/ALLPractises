namespace Dictionary1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> keyValuePairs = new Dictionary<int, Employee>();
            keyValuePairs.Add(1, new Employee
            {
                Id = 1,
                Name = "Test",
                State = "AP",
                Country = "INDIA"
            });
            keyValuePairs.Add(2, new Employee
            {
                Id = 2,
                Name = "Test1",
                State = "AP1",
                Country = "INDIA1"
            });

            var list= keyValuePairs.Where(s=>s.Value.Name == "Test" || s.Value.Country=="India1").ToList();
            foreach (KeyValuePair<int, Employee> item in list)
            {
                item.Value.Id = item.Key;
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value.Name);
            }
            /*======================End=============*/
            Console.WriteLine(" ");


            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Education { get; set; }
    }
}
