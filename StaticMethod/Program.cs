using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            ABC.M();
            ABC.M2();
        }
    }
    public class ABC
    {
        const int myNum = 15;
        public static int M()
        {
            int a = 123;
            return a;
        }
        public static void M2()
        {
            int a = 345;
        }

    }
}
