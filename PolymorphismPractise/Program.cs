using System.Drawing;

namespace PolymorphismPractise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("<============Operator overloading +==================>");

            Console.WriteLine("Enter a Value for x");
            Console.WriteLine("Enter a Value for y");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            // using overloaded - operator 
            // with the class object

            Calculator calc = new Calculator(x, y);

            //Giving input negative and out put will be positive number
            calc = -calc;
            //Console.WriteLine(" ");
            //calc = +calc;
            // To display the result
            calc.Print();
            

        }
    }
}
