using System.Runtime.CompilerServices;

namespace LinqToManyMethodSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asdasd
            //Using Method Syntax
            List<string> MethodSyntax = Student.GetStudents().SelectMany(std => std.Programming).ToList();
            //foreach (var item in MethodSyntax)
            //{
            //    Console.WriteLine("" + item);
            //}

            // how to remove duplicate records using method syntax

            var duplicates = Student.GetStudents()
                            .SelectMany(std => std.Programming)
                            .Distinct()
                            .ToList();
            //foreach (var item in duplicates)
            //{
            //    Console.WriteLine("" + item);
            //}

            //We want to retrieve the student’s name and the program names.
            //Using Method Syntax
            var MethodSyntax1 = Student.GetStudents()
                                        .SelectMany(std => std.Programming,
                                             (student, program) => new
                                             {
                                                 StudentName = student.Name,
                                                 ProgramName = program
                                             }
                                             )
                                        .ToList();

            //Query syntax
            var querylist = (from std in Student.GetStudents()
                             from program in std.Programming
                             select new
                             {
                                 StudentName = std.Name,
                                 ProgramName = program
                             }).ToList();



            //foreach (var item in MethodSyntax1)
            //{
            //    Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            //}
            var sss = Student.GetStudents().Where(s => s.Name.StartsWith("s") || s.Name.EndsWith("a") || s.Name.Length > 5).ToList();
            foreach (var item in sss)
            {
                Console.WriteLine(" " + item.Name);
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Jave", "C++"} },
                new Student(){ID = 2, Name = "Sam", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new Student(){ID = 3, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Jave", "LINQ"} },
                new Student(){ID = 4, Name = "Sara", Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
            };
        }
    }
}
