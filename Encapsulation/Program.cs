using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {


           Console.ReadLine();
        }
    }

    /*Encapsulation means WRAPPING of data
         and methods into a single unit.
        */
    public class Employee
    {
        //Make fields private
        private int empExperience;
        public int EmployeeExperience
        {
            get { return empExperience; }
            set { empExperience = value; }
        }
    }
}
