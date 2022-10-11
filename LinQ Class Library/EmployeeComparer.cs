using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Class_Library
{
    public class EmployeeComparer : IComparer<Employee>
    {
        CompareBy compareBy; 
        public enum CompareBy
        {
            age, 
            HireDate 
        }

        public EmployeeComparer(CompareBy compareBy)
        {
            this.compareBy = compareBy; 
        }

        public int Compare(Employee x, Employee y)
        {
            if (compareBy == CompareBy.age)
            {
                return x.age.CompareTo(y.age);
            }

            else
            {
                return x.HireDate.CompareTo(y.HireDate);
            }
        }

    }
}
