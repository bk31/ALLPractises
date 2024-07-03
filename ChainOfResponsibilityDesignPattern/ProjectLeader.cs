using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern_LeaveApproval
{
    //Concrete Handler 2
    //The following class implement the EmployeeLeaveHandler abstract class and 
    //Provide Implementation for ApplyLeave abstract method
    public class ProjectLeader : EmployeeLeaveHandler
    {
        // ProjectLeader can only approve up to 20 days of leave
        private readonly int MAX_LEAVES_CAN_APPROVE = 20;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            //Check if ProjectLeader can process this request
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine($"Project Leader Approved {NumberOfDaysLeave} Days Leave for the Employee {EmployeeName}");
            }
            //If ProjectLeader can't process the LeaveRequest then pass it on to the supervisor(HR) 
            // so that he can process
            else
            {
                Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
            }
        }
    }
}
