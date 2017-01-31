using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>
            {
                new Student
                {
                    Name="Tom",
                    Gender="Male",
                    Subjects=new List<string> {"Asp.Net","C#" }
                },
                new Student
                {
                    Name="Mike",
                    Gender="Male",
                    Subjects=new List<string> {"Ado.Net","C#","Ajax" }
                },
                new Student
                {
                    Name="Pam",
                    Gender="Female",
                    Subjects=new List<string> {"Wcf","Sql Server","C#" }
                },
                new Student
                {
                    Name="Mary",
                    Gender="Female",
                    Subjects=new List<string> {"Wpf","Linq","Asp.Net" }
                },
            };
            return listStudents;
        }
        static void Main(string[] args)
        {
            IEnumerable<string> allSubjects = //GetAllStudents().SelectMany(s => s.Subjects);
                (from Student in GetAllStudents() from subject in Student.Subjects select subject).Distinct();

            foreach (string subject in allSubjects)
            {
                //Console.WriteLine(subject);
            }

            string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            var result = //stringArray.SelectMany(a => a);
                from s in stringArray from c in s select c;
            foreach (char c in result)
            {
                //Console.WriteLine(c);
            }
            var results = //GetAllStudents().SelectMany(a => a.Subjects, (student, subject) => new { StudentName = student.Name, Subject = subject });
                from student in GetAllStudents() from subject in student.Subjects select new { StudentName = student.Name, Subject = subject };

            foreach (var v in results)
            {
                Console.WriteLine(v.StudentName+"-"+v.Subject);
            }

            Console.Read();
        }
    }
}
