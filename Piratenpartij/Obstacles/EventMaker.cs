using Piratenpartij.Obstacles.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Piratenpartij.Obstacles
{
    class EventMaker
    {
        //All of the events with their predefined probability
        readonly static Dictionary<EventType, int> EVENTS_PROBABILITY = new Dictionary<EventType, int>() {
            { EventType.ISLAND, 10 },
            { EventType.NONE, 10 },
            { EventType.HARBOR, 10 },
            { EventType.MERCHANT_SHIP, 35 },
            { EventType.PIRATES_SHIP, 35 }
        };
       
        readonly static Random random = new Random();

        //Get a random Event according to its probability 
        public static Event GetRandomly()
        {
            EventType selectedEvent = EventType.PIRATES_SHIP;
            int probability = 0;
            int randomValue = random.Next(1, 101);
            foreach(KeyValuePair<EventType, int> pair in EVENTS_PROBABILITY)
            {
                probability += pair.Value;
                if (randomValue <= probability)
                {
                    selectedEvent = pair.Key;
                    break;
                }
            }
            return new Event(selectedEvent);
        }

        //Get list of randomly events depend on Ship's current location and destination
        public static List<Event> GetEvents(Ship.Ship ship)
        {
            Trip tripOfShip = Trip.GetTrip(ship.CurrentLocation, ship.Destination);
            int countOfEvent = TripDifficulty.GetDifficulty(tripOfShip);
            List<Event> events = new List<Event>(countOfEvent);
            Dictionary<EventType, int> counts = new Dictionary<EventType, int>();
            foreach (KeyValuePair<EventType, int> pair in EVENTS_PROBABILITY)
            {
                int count = (int)Math.Round((double)(pair.Value * countOfEvent) / 100);
                counts.Add(pair.Key, count);
            }
            int estimatedCount = counts.Sum<KeyValuePair<EventType, int>>(e => e.Value);
            //According to probability inequality of estimated counts with exact size then checking the equality is mandatory
            if (estimatedCount < countOfEvent)
            {
                int last = counts.Last().Value;
                counts.Remove(counts.Keys.Last());
                counts.Add(EVENTS_PROBABILITY.Keys.Last(), countOfEvent - estimatedCount);
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
            return events.OrderBy<Event, int>(e => rand.Next()).ToList();
        }

    }
}
