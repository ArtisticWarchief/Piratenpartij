using Piratenpartij.Obstacles.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Piratenpartij.Obstacles
{
    class EventMaker
    {
        //All of the events with their predefined probability
        readonly Dictionary<EventType, int> EVENTS_PROBABILITY = new Dictionary<EventType, int>() {
            { EventType.ISLAND, 10 },
            { EventType.HARBOR, 10 },
            { EventType.MERCHANT_SHIP, 40 },
            { EventType.PIRATES_SHIP, 40 }
        };

        readonly Random random = new Random();

        //Get list of randomly events depend on Ship's current location and destination
        public List<Event> GetEvents(Location start, Location end, int diff)
        {
            List<Event> events = new List<Event>(diff);
            Dictionary<EventType, int> counts = new Dictionary<EventType, int>();
            foreach (KeyValuePair<EventType, int> pair in EVENTS_PROBABILITY)
            {
                int count = (int)Math.Round((double)(pair.Value * diff) / 100);
                counts.Add(pair.Key, count);
            }
            int estimatedCount = counts.Sum<KeyValuePair<EventType, int>>(e => e.Value);
            //According to probability inequality of estimated counts with exact size then checking the equality is mandatory
            if (estimatedCount < diff)
            {
                int last = counts.Last().Value;
                counts.Remove(counts.Keys.Last());
                counts.Add(EVENTS_PROBABILITY.Keys.Last(), diff - estimatedCount);
            }
            foreach (KeyValuePair<EventType, int> count in counts)
            {
                for (int i = 0; i < count.Value; i++)
                {
                    if (events.Count == events.Capacity) break;
                    events.Add(new Event(count.Key));
                }
            }
            //shuffle the events list
            Random rand = new Random();
            List<Event> result = events.OrderBy<Event, int>(e => rand.Next()).ToList();
            return result;
        }

    }
}
