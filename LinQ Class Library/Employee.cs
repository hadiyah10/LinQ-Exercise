using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Class_Library
{
    public class Employee : IEquatable<Employee>
    {
        public String Name { get; set; }
        public int age { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(String Name, int age, DateTime HireDate)
        {
            this.Name = Name;
            this.age = age;
            this.HireDate = HireDate;
        }

        public int CompareTo(Object obj)
        {
            return age.CompareTo((obj as Employee).age);
        } 

        public bool Equals(Employee other)
        {
            return Name == other.Name && age == other.age && HireDate == other.HireDate;
        }
    }
}
