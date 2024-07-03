using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskaWaitNAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A.Demo();



            Console.ReadLine();
        }
    }
    public class A
    {
        public static string Name = "babuK";
        public static string Description = "Software Engineer";
        public static void Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = StartSchoolAssembly();
            var task2 = TeachClass12();
            var task3 = TeachClass11();
            var task4 = Sample();

            Task.WaitAll(task1, task2, task3, task4);
            watch.Stop();
            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds}ms");
        }
        public static async Task Sample()
        {
            await Task.Run(() =>
            {
                Console.WriteLine(Name.Contains("babuK") ? "Good day for you Babu K." : "Good evening.");
                Thread.Sleep(10000);
                Console.WriteLine(Description.Contains("Software Engineer") ? "Good day  to Babu K ." : "Good evening.");

            });
        }
        public static async Task StartSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("School Started");
            });
        }


        public static async Task TeachClass12()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class 12");
            });


        }

        public static async Task TeachClass11()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class 11");
            });


        }
        public static async Task TechSystems()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("One day will clear the all inter tech stacks like DS and Algorithms");
                Thread.Sleep(4000);
                Console.WriteLine("Hell");
            });
        }
    }
}
