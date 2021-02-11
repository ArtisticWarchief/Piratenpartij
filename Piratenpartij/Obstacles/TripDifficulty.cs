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
        // List of all trips that exist in the game
        private readonly static List<KeyValuePair<Trip, int>> TRIPS = new List<KeyValuePair<Trip, int>>() 
        {
            new KeyValuePair<Trip, int>(Trip.GetTrip(Location.AS, Location.EU), 10),
            new KeyValuePair<Trip, int>(Trip.GetTrip(Location.EU, Location.US), 5),
            new KeyValuePair<Trip, int>(Trip.GetTrip(Location.US, Location.AS), 7)
        };

        public static List<KeyValuePair<Trip, int>> GetTrips()
        {
            return TRIPS;
        }
        //Get trip difficulty of the trip between location a and b
        public static int GetDifficulty(Location a,Location b)
        {
            if (a != b && a != Location.ON_BOARD && b != Location.ON_BOARD)
            {
                return TripDifficulty.GetTrips()
                   .Where(trip => trip.Key.Start == a && trip.Key.End == b || trip.Key.End == a && trip.Key.Start == b)
                   .First().Value;
            }
            else
            {
                return 0;
            }

        }
    }
    
}
