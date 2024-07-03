using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ABC a = new ABC();
            B B = new B("babu K from B class");
            C c = new C();
            Console.ReadLine();
        }
    }
    public sealed class ABC
    {
        public ABC()
        {
            Console.WriteLine(" Hi ABC sealed class");

        }
    }
    public sealed class A
    {
        private A()
        {
            Console.WriteLine(" in Sealed class A Private constuctor called");
        }
    }
    public class B
    {
        private B()
        {
            Console.WriteLine(" Priavate class B called");

        }
        static B()
        {
            Console.WriteLine(" static constuctor called from  class B ");

        }
        public B(string name)
        {
            name = "Babu K from parameter construct B class";
            Console.WriteLine(name);
        }
    }
    public sealed class C
    {
        static C()
        {
            Console.WriteLine(" static constuctor called from  sealed class C");

        }

        //Destructor in sealed class can be used but not in static class 
        ~C()
        {

        }
    }
}
