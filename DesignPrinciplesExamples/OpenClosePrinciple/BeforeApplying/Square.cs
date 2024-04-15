using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.OpenClosePrinciple.BeforeApplying
{
    internal class Square : Rectangle
    {

        private int _side;

        public override int Height { get => _side ; set => _side = value; }
        public override int Width { get => _side; set => _side = value; }
    }
}
