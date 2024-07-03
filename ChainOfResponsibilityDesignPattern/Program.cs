using ChainOfResponsibilityDesignPattern_LeaveApproval;
using System.Diagnostics;

namespace ChainOfResponsibilityDesignPattern
{

    //LINK : https://dotnettutorials.net/lesson/chain-of-responsibility-design-pattern/
    public class Program
    {
        static void Main(string[] args)
        {
            TeamLeader teamLeader = new TeamLeader();
            ProjectLeader projectLeader = new ProjectLeader();
            HR hr = new HR();
            teamLeader.SetNextSupervisor(projectLeader);
            projectLeader.SetNextSupervisor(hr);

            teamLeader.ApplyLeave("Babu K", 9);
            Console.WriteLine(" \t");
            projectLeader.ApplyLeave("Pooja Kumari", 12);
            Console.WriteLine(" \t");
            projectLeader.ApplyLeave("Rama Lakshmi Marni Govinda", 12);



            Console.WriteLine("<==========================================================>\t");
            teamLeader.ApplyLeave("Anurag", 9);
            Console.WriteLine();
            teamLeader.ApplyLeave("Pranaya", 18);
            Console.WriteLine();
            teamLeader.ApplyLeave("Priyanka", 30);
            Console.WriteLine();
            teamLeader.ApplyLeave("Ramesh", 50);

            Console.ReadLine();
        }
    }
    

    
}
