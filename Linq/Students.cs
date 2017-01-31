using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Students
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Students> GetAllStudents()
        {
            List<Students> listStudents = new List<Students>();

            Students student1 = new Students
            {
                ID = 101,
                Name = "Prava",
                Gender = "Male"
            };
            listStudents.Add(student1);
            Students student2 = new Students
            {
                ID = 101,
                Name = "Priya",
                Gender = "Female"
            };
            listStudents.Add(student2);
            return listStudents;
        }
        static void Main(string[] args)
        {
            List<Students> lstStudent = Students.GetAllStudents().Where(a=>a.Gender=="Male").ToList();
            for (int i = 0; i < lstStudent.Count; i++)
            {
                Console.WriteLine(lstStudent[i].ID);
                Console.WriteLine(lstStudent[i].Name);
                Console.WriteLine(lstStudent[i].Gender);
            }
            Console.ReadLine();
        }

    }
}
