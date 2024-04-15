using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.OpenClosePrinciple.AfterApplying
{
    internal class Square : IArea
    {
        public int Side { get; set; }

        public int Area()
        {
            return Side * Side;
        }
    }
}
