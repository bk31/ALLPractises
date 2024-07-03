using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Program
    {
        static void Main(string[] args)
        {
            LocalShipper shipper = new LocalShipper();
          // Shipper shipper1 = new Shipper();
            //shipper1.ScheduleDelivery("bk");
            shipper.ScheduleDelivery("bab");
            Console.ReadLine();
        }
    }

    public class Shipper
    {
        public virtual void ScheduleDelivery(string destination)
        {
            Console.WriteLine($"Scheduling delivery to {destination}.");
        }
    }
    public class LocalShipper : Shipper
    {
        public override void ScheduleDelivery(string destination)
        {
            if (destination == "International") // Precondition Strengthening
            {
                // Throwing an unexpected Exception type
                throw new InvalidOperationException("Local shippers cannot handle international shipments.");
            }
            Console.WriteLine($"Scheduling local delivery to {destination}.");
        }
    }
}
