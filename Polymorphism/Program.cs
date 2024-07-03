namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
             Polymorphism polymorphism = new Polymorphism();
            int add = polymorphism.Add(12, 23);
            string str = polymorphism.Add("Babu ", " k");

            Console.WriteLine(add);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
    /*
     * Polymorphism is the ability of a variable, 
      object, or function to take on MULTIPLE 
       FORMS.
    */

    public class Polymorphism
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
