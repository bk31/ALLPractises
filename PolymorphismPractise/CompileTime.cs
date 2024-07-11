using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractise
{
    public class CompileTimeMethodOverLoading
    {
        public int Add(int a, int b)
        {
            Console.WriteLine($" Method overloading {a + b}");
            return a + b;

        }
        public double Add(double a, double b)
        {
            Console.WriteLine($" Method overloading {a + b}");
            return a + b;
        }
        public string Add(string a, string b)
        {
            Console.WriteLine($" Method overloading {a + b}");
            return a + b;
        }
    }

    //CompileTimeOperatorOverloading
    public class Calculator
    {
        public int number1, number2;
        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }


        // Function to perform operation
        // By changing sign of integers
        public static Calculator operator -(Calculator c)
        {

            // Calculator cc = new Calculator();
            c.number1 = -c.number1;
            c.number2 = -c.number2;
            return c;

        }


        // Function to perform operation
        // By changing sign of integers
        public static Calculator operator +(Calculator c)
        {

            // Calculator cc = new Calculator();
            c.number1 = +c.number1;
            c.number2 = +c.number2;
            return c;

        }


        // Function to print the numbers
        public void Print()
        {
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
        }

        // Function to print the numbers
        //public void Prin1t()
        //{
        //    Console.WriteLine("Number1 = " + number1);
        //    Console.WriteLine("Number2 = " + number2);
        //}
    }
}
