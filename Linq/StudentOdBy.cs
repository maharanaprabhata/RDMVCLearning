using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class StudentOdBy
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<StudentOdBy> GetAllStudent()
        {
            List<StudentOdBy> listStudentOdBy = new List<StudentOdBy>
            {
            new StudentOdBy
            {
                StudentID = 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new StudentOdBy
            {
                StudentID = 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new StudentOdBy
            {
                StudentID = 103,
                Name = "Mary",
                TotalMarks = 800
            },
            new StudentOdBy
            {
                StudentID = 104,
                Name = "John",
                TotalMarks = 800
            },
            new StudentOdBy
            {
                StudentID= 105,
                Name = "John",
                TotalMarks = 800
            },
            };
            return listStudentOdBy;
        }
        static void Main(string[] args)
        {
            IEnumerable<StudentOdBy> result = //GetAllStudent().OrderByDescending(a => a.Name);
                                              // from student in GetAllStudent() orderby student.Name descending select student;
                                              //GetAllStudent().OrderBy(a => a.TotalMarks).ThenBy(a => a.Name).ThenBy(a => a.StudentID);
               from student in GetAllStudent() orderby student.TotalMarks, student.Name, student.StudentID descending select student;

            foreach (var student in result)
            {
                // Console.WriteLine(student.Name);
                Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
            }
            Console.Read();
        }
    }
}
