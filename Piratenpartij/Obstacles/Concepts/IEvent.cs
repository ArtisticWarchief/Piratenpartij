using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Obstacles.Concepts
{
    interface IEvent
    {
        List<Event> Events { get; set; }
    }
}
