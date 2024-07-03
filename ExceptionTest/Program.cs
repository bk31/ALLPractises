using System.Net;

namespace ExceptionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var emp = new Employee()
            //{
            //    Id=1,
            //    Name="Babu",
            //};
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(){ Id=1,Name="tess"});
            list.Add(new Employee(){ Id=2,Name="Babu K"});
            list.Add(new Employee(){ Id=3,Name="Sandy"});
            list.Add(new Employee(){ Id=4,Name="Vamis"});
            list.Add(new Employee(){ Id=5,Name="Savitha"});

            var lists= list.Where(s=>s.Id==2 || s.Name=="Babu").ToList();
            foreach(Employee e in lists)
            {
                Console.WriteLine(e.Name);  
            }
            Console.ReadLine();

        }
    }
    public class  Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class Employee2
    {
        public virtual int GetSalary(int a)
        {
            return a;
        }
    }
    public class Student : Employee2
    {
        public override int GetSalary(int a)
        {
            return base.GetSalary(a);
        }
    }
}
