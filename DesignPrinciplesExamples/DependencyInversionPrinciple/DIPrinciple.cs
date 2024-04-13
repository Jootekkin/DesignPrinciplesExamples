using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.DependencyInversionPrinciple
{
    internal class DIPrinciple
    {
        private ISender _sender;

        public DIPrinciple(ISender sender)
        {
            _sender = sender;
        }

        public void PrintMsg(string msg)
        {
            Console.WriteLine(_sender.SendMsg(msg));
        }
    }
}
