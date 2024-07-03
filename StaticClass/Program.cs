using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class A
    {
        // Cannot use access modifiers on static constuctors because implicitly it is private
        /*
         private static A()
         {

         }
        */

        static A()
        {

        }

        // Cannot use destructors in static class
        /*
        ~A()
         {

         }
        */
        
    }
}
