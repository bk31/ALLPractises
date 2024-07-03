using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The client
namespace StrategyPattern
{
    public class CalculateClient
    {
        private ICalculateInterface calculateInterface;
        //Constructor: assigns strategy to interface  
        public CalculateClient(ICalculateInterface calculateInterface)
        {
            this.calculateInterface = calculateInterface;
        }
        public int Calculate(int value1,int value2)
        {
            return calculateInterface.Calculate(value1,value2);
        }
    }
}
