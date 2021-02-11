using System;
using System.Collections.Generic;
using System.Linq;

namespace Piratenpartij.Obstacles
{
    class EventMaker
    {
        //sort of events with their probability
        readonly static List<KeyValuePair<EventType, int>> pairs = new List<KeyValuePair<EventType, int>>() {
            new KeyValuePair<EventType, int>(EventType.ISLAND, 10),
            new KeyValuePair<EventType, int>(EventType.NONE, 10),
            new KeyValuePair<EventType, int>(EventType.HARBOR, 10),
            new KeyValuePair<EventType, int>(EventType.MERCHANT_SHIP, 35),
            new KeyValuePair<EventType, int>(EventType.PIRATES_SHIP, 35)
        };
        private EventMaker() { }

        public static EventMaker instance;

        public static EventMaker GetInstance()
        {
            if(instance == null)
            {
                instance = new EventMaker();
            }
            return instance;
        }

        readonly static Random random = new Random();
        public static Event GetRandomly()
        {
            EventType selectedEvent = EventType.NONE;
            int probability = 0;
            int randomValue = random.Next(1, 101);
            for (int i = 0; i < pairs.Count; i++)
            {
                probability += pairs[i].Value;
                if (randomValue <= probability)
                {
                    selectedEvent = pairs[i].Key;
                    break;
                }
            }
            return new Event(selectedEvent);
        }
    }
}
