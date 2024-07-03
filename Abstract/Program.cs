namespace Abstract
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

           int sal= employee.CalculateSalary();
            Console.WriteLine(sal);
            Console.ReadLine();
        }
    }

    /*
     Abstraction means showing only required 
     things and hide the BACKGROUND details.
      
     */
    public abstract class EmployeeSalary
    {
        public int CalculateSalary()
        {
            return 10 * 30000;
        }
    }
    public class Employee : EmployeeSalary
    {

    }
}
