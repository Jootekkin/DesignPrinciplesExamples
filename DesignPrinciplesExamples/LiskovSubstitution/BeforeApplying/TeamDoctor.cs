using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.LiskovSubstitution.BeforeApplying
{
    internal class TeamDoctor : TeamMember
    {
        public override void Healing()
        {
            //Doctor Use this
            base.Healing();
        }

        public override void Playing()
        {
            //Doctor Don;t use this
            base.Playing();
        }
    }
}
