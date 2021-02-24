using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Obstacles
{
    //CombatEvent could happen against a Pirates ship along a trip
    public class CombatEvent : Event
    {
        public CombatEvent() : base(EventType.PIRATES_SHIP){
         
        }
    }
}
