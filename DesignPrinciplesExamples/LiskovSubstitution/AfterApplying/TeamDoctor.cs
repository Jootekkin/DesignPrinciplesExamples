using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.LiskovSubstitution.AfterApplying
{
    internal class TeamDoctor : IHealer
    {
        public void Healing()
        {
            //Doctor Healing
            throw new NotImplementedException();
        }
    }
}
