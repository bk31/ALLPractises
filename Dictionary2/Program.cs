using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<string>> keyValuePairs = new Dictionary<int, List<string>>();

            keyValuePairs.Add(1, new List<string>() { "BAbuK" });
            keyValuePairs.Add(2, new List<string>() { "Age is 26" });
            keyValuePairs.Add(3, new List<string>() { "BE" });
            keyValuePairs.Add(4, new List<string>() { "CSE" });
            keyValuePairs.Add(5, new List<string>() { "GTR" });
            keyValuePairs.Add(6, new List<string>() { "AP" });
            foreach (KeyValuePair<int, List<string>> keyValuePairs1 in keyValuePairs)
            {
                if (keyValuePairs1.Key == 1)
                    Console.WriteLine(keyValuePairs1.Key + "  >>>>>  " + keyValuePairs1.Value.AsQueryable().FirstOrDefault());
            }

            Dictionary<int, List<string>> keyValuePairss = new Dictionary<int, List<string>>();
            keyValuePairss.Add(1, new List<string>() { "Babu k" });
            keyValuePairss.Add(2, new List<string>() { "Babu k" });
            keyValuePairss.Add(3, new List<string>() { "Babu k" });
            keyValuePairss.Add(5, new List<string>() { "Babu k" });
            keyValuePairss.Add(6, new List<string>() { "Babu k" });
            foreach (KeyValuePair<int, List<string>> item in keyValuePairss)
            {
                Console.WriteLine(item.Key + " " + item.Value.AsQueryable().FirstOrDefault());
            }

            Console.ReadLine();
        }
    }
    public abstract class AA
    {

        public abstract void Sample();
    }
    public abstract class AB
    {

        public abstract void SampleOne();
    }
    public class A : AA
    {
        public override void Sample()
        {
            throw new NotImplementedException();
        }
    }
    public class ABB : AA
    {
        public override void Sample()
        {
            throw new NotImplementedException();
        }
    }
    

}
