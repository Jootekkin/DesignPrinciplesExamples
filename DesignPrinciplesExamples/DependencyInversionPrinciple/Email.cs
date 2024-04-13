using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.DependencyInversionPrinciple
{
    internal class Email : ISender
    {
        public string SendMsg(string msg)
        {
            return $"{msg} message by email";
        }
    }
}
