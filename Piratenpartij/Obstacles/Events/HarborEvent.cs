using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Obstacles
{
    //Trade Event could happen whenever a harbor appears along a trip
    public class HarborEvent : Event
    {
        public HarborEvent() : base(EventType.HARBOR)
        {

        }
    }
}
