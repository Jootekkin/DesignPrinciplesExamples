using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.ENCAPSULATEWhatVaries
{
    public class EncapsulateWhatVaries
    {

        #region BeforeApplying
        public string EmployeeType { get; set; }

        public double CalculateBonus(double salary)
        {
            if (EmployeeType == "Permanent")
            {
                return salary * 0.1;
            }
            else if (EmployeeType == "Contract")
            {
                return salary * 0.05;
            }
            else
            {
                return 0;
            }
        }
        #endregion


        
    }
}
