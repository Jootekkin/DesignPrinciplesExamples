using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.ENCAPSULATEWhatVaries.AfterApplying
{
    public class Employee
    {
        private IEmployee _EmployeeType;

        public Employee(IEmployee EmployeeType) 
        {
        _EmployeeType = EmployeeType;
        }

        public double CountBonus(double salary)
        {
            return _EmployeeType.CountBonus(salary);
        }
    }
}
