using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.KISSPrinciple
{
    public  class KissPrinciple2
    {
        #region BeforeApply
        public string IsEvenOrOdd(int number)
        {
            if ((number % 2) == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        #endregion
    }
}
