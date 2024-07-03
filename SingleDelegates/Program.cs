namespace SingleDelegates
{
    public delegate void MatthDelegate(int a, int b);
    public class Program
    {
        static void Main(string[] args)
        {
            //Single Caste Delegates
            Delagates obj = new Delagates();
            MatthDelegate addDelegate = new MatthDelegate(obj.subtract);
            MatthDelegate addDelegate1 = new MatthDelegate(obj.sum);
                        
            addDelegate(13, 134);
            addDelegate1(13, 134);
            Console.WriteLine("Mutlicaste delegate ===>\t");   
            MulticasetDelegates mutlidel = new MulticasetDelegates();
            DelegateMethod delegateMethod = new DelegateMethod(mutlidel.plus_Method1);

            delegateMethod += mutlidel.subtract_Method2;
            delegateMethod += mutlidel.plus_Method1;

            delegateMethod(123, 123);
            Console.ReadKey();
        }
    }
    public class Delagates
    {
        // method "sum"
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

    }
}
