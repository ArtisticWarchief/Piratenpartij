using System;
using System.Collections.Generic;


namespace Piratenpartij.Obstacles.Enums
{
    public class Trip
    {

        public Location Start { get; set; }
        public Location End { get; set; }
        public List<Event> Events { get; set; } 
        public int Difficulty { get; set; }

        readonly Random random = new Random();
        
        public Trip(Location start, Location end)
        {
            Start = start;
            End = end;
            Difficulty = random.Next(10, 20);
            Events = new EventMaker().GetEvents(start, end, Difficulty);
        }

        public Trip() : this(Location.AS, Location.US) { }

    }
}
