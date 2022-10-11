using LinQ_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                 new Employee("James", 25, new DateTime(2000, 05, 01)),
                 new Employee("Jane", 21, new DateTime(2010, 05, 03)),
                 new Employee("Frank", 40, new DateTime(2022, 05, 05)),
                 new Employee("Frank", 40, new DateTime(2023, 05, 05))
            };

            if (employees != null && employees.Count > 0)
            {
                //return a list of employees that are hired after the year 2005
                var employeeAfter2005 = employees.Where(z => z.HireDate > new DateTime(2005, 01, 01)).ToList();
            
                foreach (Employee emp in employeeAfter2005)
                {
                    Console.WriteLine(emp.Name);
                }

                //if any were hired during year 2015
                var during2015 = employees.Any(z => z.HireDate > new DateTime(2015, 01, 01));
                Console.WriteLine(during2015);

                //Find if all employees are above the age of 18 (should return a bool)
                var above18 = employees.All(z => z.age > 18);
                Console.WriteLine(above18); 

                //Find and return the employee that has been in the company the longest
                var longestTimeEmployee = employees.OrderBy(z => z.HireDate).First();
                Console.WriteLine(longestTimeEmployee.Name);

                //Get a List of employees ordered by Name then by HireDate, and return the first element (without using indexing)
                var first = employees.OrderBy(z => z.Name).OrderBy(z => z.HireDate).FirstOrDefault();
                Console.WriteLine(first.Name);

                //Return a List of the unique names of the employees
                var uniqueName = employees.Select(x => x.Name).Distinct().ToList(); 
                foreach(string emp in uniqueName)
                {
                    Console.WriteLine(emp);
                }

                //Return the first employee that is older than 50 years old, if none exist, return null
                var employeeOlder50 = employees.Where(z => z.age > 50).FirstOrDefault();

                if (employeeOlder50 != null)
                    Console.WriteLine(employeeOlder50.Name);
                else
                    Console.WriteLine("Null");

                //Validate that there is only one employee that has the name “Jane” and return the employee (one single Linq method) 
                var singleEmployee = employees.SingleOrDefault(z => z.Name.Equals("Jane"));
                Console.WriteLine(singleEmployee);

                Console.ReadKey();  
            }
        }
    }
}
