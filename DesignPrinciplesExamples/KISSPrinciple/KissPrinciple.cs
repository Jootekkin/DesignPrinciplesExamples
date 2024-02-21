using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.KISSPrinciple
{
    internal class KissPrinciple
    {

        #region BeforeApply
        public bool IsPositive(int number)
            {
                if (number > 0)
                {
                    return true;
                }
                else if (number <= 0)
                {
                    return false;
                }
                else
                {
                    throw new Exception("Invalid number");
                }
            }
        #endregion


        #region AfterApply
        public bool IsPositive(decimal number)
        {
            return number > 0;
        }
        #endregion
    }
}
