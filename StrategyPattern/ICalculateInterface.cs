using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///The interface for the strategies
namespace StrategyPattern
{
    public interface ICalculateInterface
    {
        //define method  
        int Calculate(int value1, int value2);
    }
}
