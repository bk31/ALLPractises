using static RunTimePolymorphishm.BaseClass;

namespace RunTimePolymorphishm
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass;
            baseClass = new ChildClass();
            baseClass.Sample2();
            baseClass.Sample3();
           
            Console.ReadLine();


        }
    }
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base  Constructor Called");
        }
        public void Sample2()
        {
            Console.WriteLine("Base Called Sample2");

        }
        public virtual void Sample3()
        {
            Console.WriteLine("Base virtual  Called Sample3");

        }
        public class ChildClass : BaseClass
        {
            public ChildClass()
            {
                Console.WriteLine("Child class Constructor Called");
            }
            static ChildClass()
            {
                Console.WriteLine(" static Child class Constructor Called");

            }
            public void Sample()
            {
                Console.WriteLine("Child Called Sample");

            }
            //public override void Sample3()
            //{
            //    Console.Write("HI from kids");
            //}


        }
    }
}
