using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>
        {
            new Employee
            {
                EmployeeID = 101,
                FirstName = "Tom",
                LastName = "Daely",
                Gender = "Male",
                AnnualSalary = 60000
            },
            new Employee
            {
                EmployeeID = 102,
                FirstName = "Mike",
                LastName = "Mist",
                Gender = "Male",
                AnnualSalary = 72000
            },
            new Employee
            {
                EmployeeID = 103,
                FirstName = "Mary",
                LastName = "Lambeth",
                Gender = "Female",
                AnnualSalary = 48000
            },
            new Employee
            {
                EmployeeID = 104,
                FirstName = "Pam",
                LastName = "Penny",
                Gender = "Female",
                AnnualSalary = 84000
            },
        };

            return listEmployees;
        }
        static void Main(string[] args)
        {
            IEnumerable<int> employeeID = GetAllEmployees().Select(a => a.EmployeeID);
            foreach (var empId in employeeID)
            {
                Console.WriteLine(empId);
            }
            Console.WriteLine("--------------------------");
            var result = GetAllEmployees().Select(a => new
            {
                FirstName = a.FirstName,
                Gender = a.Gender
            });
            foreach (var res in result)
            {
                Console.WriteLine(res.FirstName+"-"+res.Gender);
            }
            Console.WriteLine("_______________________________________");
            var results = GetAllEmployees().Select(a => new
            {
                FullName = a.FirstName + " " + a.LastName,
                MonthlySalary = a.AnnualSalary / 12
            });
            foreach (var v in results)
            {
                Console.WriteLine(v.FullName+"-"+v.MonthlySalary);
            }
            Console.WriteLine("-----------------------------------");
            var resu = GetAllEmployees().Where(a => a.AnnualSalary > 50000).Select(a => new
            {
                Name = a.FirstName,
                Salary = a.AnnualSalary,
                Bonus = a.AnnualSalary * .1
            });

            foreach (var v in resu)
            {
                Console.WriteLine(v.Name+"-"+v.Salary+"-"+v.Bonus);
            }
            Console.ReadLine();
        }
    }
}
