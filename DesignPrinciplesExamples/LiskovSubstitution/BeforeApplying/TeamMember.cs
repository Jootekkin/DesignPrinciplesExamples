using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.LiskovSubstitution.BeforeApplying
{
    public class TeamMember
    {
        public virtual void Playing()
        {
            //Football player 
            //Playing football
        }

        public virtual void Healing()
        {
            //Medicine Crow
            //Help players to heal
        }
    }
}
