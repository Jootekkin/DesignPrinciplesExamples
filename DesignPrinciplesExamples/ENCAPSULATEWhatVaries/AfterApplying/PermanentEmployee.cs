using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.ENCAPSULATEWhatVaries.AfterApplying
{
    public class PermanentEmployee : IEmployee
    {
        public double CountBonus(double salary)
        {
            return salary * 0.5;
        }
    }
}
