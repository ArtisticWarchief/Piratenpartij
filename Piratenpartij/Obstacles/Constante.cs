using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Obstacles
{
    public class Constante
    {
        public List<KeyValuePair<Destination, int>> DESTINATIONS = new List<KeyValuePair<Destination, int>>() 
        {
            new KeyValuePair<Destination, int>(Destination.EU_AS, 10),
            new KeyValuePair<Destination, int>(Destination.US_AS, 5),
        };
    }

    public enum Destination
    {
        US_EU,
        US_AS,
        EU_AS,
    }
}
