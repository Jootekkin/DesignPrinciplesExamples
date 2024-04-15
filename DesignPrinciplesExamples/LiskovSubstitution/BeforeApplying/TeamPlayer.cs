using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.LiskovSubstitution.BeforeApplying
{
    internal class TeamPlayer : TeamMember
    {
        public override void Playing()
        {
            //player use this 
            base.Playing();
        }

        public override void Healing()
        {
            //player don't use this
            base.Healing();
        }
    }
}
