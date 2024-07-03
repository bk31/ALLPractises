using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int , List<string>> keyValuePairs= new Dictionary<int,List<string>>();
            keyValuePairs.Add(1, new List<string>() { "Babu is 21"});
            keyValuePairs.Add(2, new List<string>() { "Babu is 23"});
            keyValuePairs.Add(3, new List<string>() { "Babu is 24"});
            keyValuePairs.Add(4, new List<string>() { "Babu is 43"});
            keyValuePairs.Add(5, new List<string>() { "Babu is 33"});
            keyValuePairs.Add(6, new List<string>() { "Babu is 34"});
            foreach (KeyValuePair<int,List<string>> pair in keyValuePairs)
            {
                if(pair.Key ==2 || pair.Key==3)
                Console.WriteLine(pair.Key +" is "+ pair.Value.AsQueryable().FirstOrDefault());
            }
            Console.ReadLine();
        }
    }
}
