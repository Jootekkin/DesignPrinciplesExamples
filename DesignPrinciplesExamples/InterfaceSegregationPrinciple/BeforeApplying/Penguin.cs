using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.InterfaceSegregationPrinciple.BeforeApplying
{
    internal class Penguin : IBird
    {
        public string Flaying()
        {
            //Penguin can't fly so no need for this behavior
            throw new NotImplementedException();
        }

        public string NotFlying()
        {
            //Penguin can't fly so need for this behavior
            throw new NotImplementedException();
        }
    }
}
