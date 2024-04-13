using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.InterfaceSegregationPrinciple.AfterApplying
{
    internal class Eagle : IFlying
    {
        public string Flying()
        {
            //Eagle can fly
            throw new NotImplementedException();
        }
    }
}
