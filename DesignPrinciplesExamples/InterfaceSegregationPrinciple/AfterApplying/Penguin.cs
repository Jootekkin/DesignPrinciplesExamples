using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.InterfaceSegregationPrinciple.AfterApplying
{
    internal class Penguin : INotFlaying
    {
        public string NotFlying()
        {
            //Penguin Can't Fly
            throw new NotImplementedException();
        }
    }
}
