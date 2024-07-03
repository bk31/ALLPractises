using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Step2: Creating Concrete Handlers
namespace ChainOfResponsibilityDesignPattern_LeaveApproval
{
    //Concrete Handler 1
    //The following class implement the EmployeeLeaveHandler abstract class and 
    //Provide Implementation for ApplyLeave abstract method
    public class TeamLeader : EmployeeLeaveHandler
    {
        // TeamLeader can only approve up to 10 days of leave
        private readonly int MAX_LEAVES_CAN_APPROVE = 10;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            //Check if TeamLeader can process this request
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                //ApproveLeave(EmployeeName, NumberOfDaysLeave);
                Console.WriteLine($"Team Leader Approved {NumberOfDaysLeave} Days Leave for the Employee {EmployeeName}");
            }
            //If TeamLeader can't process the LeaveRequest then pass it on to the supervisor(Project Leader)
            // so that he can process
            else
            {
                Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
            }
        }
    }
}
