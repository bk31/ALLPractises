using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Employee> Employees = new Dictionary<string, Employee>();
            Employee emp1 = new Employee("Emp01", "Employee1");
            Employee emp2 = new Employee("Emp02", "Employee2");
            Employee emp3 = new Employee("Emp03", "Employee3");
            Employee emp4 = new Employee("Emp04", "Employee4");
            Employee emp5 = new Employee("Emp05", "Employee5");
            Employees.Add(emp1.empID, emp1);
            Employees.Add(emp2.empID, emp2);
            Employees.Add(emp3.empID, emp3);
            Employees.Add(emp4.empID, emp4);
            Employees.Add(emp5.empID, emp5);
           // Console.WriteLine(Employees["Emp05"].getNameAndID());
            foreach (KeyValuePair<string, Employee> emp in Employees)
            {
                if(emp.Key == "Emp01")
                Console.WriteLine(emp.Key + "  >>>>>  " + emp.Value.empName);
               // Console.WriteLine(emp.Value.ToString());
            }
            Console.ReadLine();
        }
    }
    public class A
    {
        static Dictionary<int, string> groupInfo = new Dictionary<int, string>() { { 1, "Gold" }, { 2, "Silver" }, { 3, "Platinum" } };
        static Dictionary<int, List<String>> memberInfo = new Dictionary<int, List<String>>() {
                                    { 1, new List<string>(){ "Tom","Harry"} },
                                    { 2,new List<string>(){ "Sam","Peter"} },
                                    { 3,new List<string>(){ "Kim","Robert"} } };


    }
    public class Employee
    {
        public string empID;
        public readonly string empName;
        public Employee(string empID, string name)
        {
            this.empID = empID;
            this.empName = name;
        }
    }
}
