using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDelegates
{
    public delegate void DelegateMethod(int x, int y);
    public class MulticasetDelegates
    {
        public void plus_Method1(int x, int y)
        {
            Console.Write("You are in plus_Method");
            Console.WriteLine($"\t {x + y}");
        }

        public void subtract_Method2(int x, int y)
        {
            Console.Write("You are in subtract_Method");
            Console.WriteLine($" \t {x - y}");
        }
    }
}
