using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.InterfaceSegregationPrinciple.BeforeApplying
{
    internal class Eagle : IBird
    {
        public string Flaying()
        {
            //Eagle can fly so need for this behavior
            throw new NotImplementedException();
        }

        public string NotFlying()
        {
            //Eagle can't fly so no need for this behavior
            throw new NotImplementedException();
        }
    }
}
