namespace RunTimePolyMorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass; //= new BaseClass();
            baseClass= new DerivedClass();
            baseClass.Greetings();
            Console.ReadLine();
        }
    }

    //sdfkslkdfslkf
    /* Overriding is used to modify and provide a 
         new implementation of the method inherited 
        from a base class
    */
    public class BaseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("Hello from Base Class");
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void Greetings()
        {
            Console.WriteLine("Hello from DerivedClass");
        }
    }
}
