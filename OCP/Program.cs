using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Order
    {
       public decimal CalculateTotalCost()
        {
            return 0;
        }
        public abstract decimal CalculateDiscount();

    }

}
