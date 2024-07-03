using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class LoyalCustomerOrder : Order
    {
        public override decimal CalculateDiscount()
        {
            // Calculate discount for loyal customers
            return 0;
        }
    }
}
