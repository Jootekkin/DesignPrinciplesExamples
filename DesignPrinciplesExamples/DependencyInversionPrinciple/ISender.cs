using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.DependencyInversionPrinciple
{
    internal interface ISender
    {
        string SendMsg(string msg);
    }
}
