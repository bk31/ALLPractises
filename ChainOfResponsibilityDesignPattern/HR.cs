using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern_LeaveApproval
{
    //Concrete Handler 3
    //The following class implement the EmployeeLeaveHandler abstract class and 
    //Provide Implementation for ApplyLeave abstract method
    public class HR : EmployeeLeaveHandler
    {
        // HR can only approve up to 30 days of leave
        private readonly int MAX_LEAVES_CAN_APPROVE = 30;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine($"HR Approved {NumberOfDaysLeave} Days Leave for the employee {EmployeeName}");
            }
            else
            {
                Console.WriteLine($"Leave Application Suspended for Employee {EmployeeName}, Please contact HR");
            }
        }
    }
}
