using Piratenpartij.Obstacles.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Obstacles
{
    public class TripDifficulty
    {
        private static List<KeyValuePair<Trip, int>> DESTINATIONS_DIFFICULTY = new List<KeyValuePair<Trip, int>>() 
        {
            new KeyValuePair<Trip, int>(Trip.EU_AS, 10),
            new KeyValuePair<Trip, int>(Trip.US_AS, 5),
            new KeyValuePair<Trip, int>(Trip.US_EU, 7)
        };

        public static List<KeyValuePair<Trip, int>> GetDestinations()
        {
            return DESTINATIONS_DIFFICULTY;
        }
    }

    

    
}
