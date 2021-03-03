using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Harbors;

namespace Piratenpartij.Obstacles
{
    //Trade Event could happen whenever a harbor appears along a trip
    public class HarborEvent : Event
    {
        public Harbor Harbor  { get; }
        public HarborEvent() : base(EventType.HARBOR)
        {
            Harbor = new Harbor();
        }
    }
}
