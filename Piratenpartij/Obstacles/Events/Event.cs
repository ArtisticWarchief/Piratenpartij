using Piratenpartij.Obstacles.Enums;
using System;

namespace Piratenpartij.Obstacles
{
    public class Event
    {

        public EventType EventType { get; set; }
        public int Power { get; set; }

        public EventStatus Status { get; set; }

        //static is mandatory to make correctly a random difficulty per each instance of Event
        static readonly Random random = new Random();

        public Event(){ }
        public Event(EventType eventType)
        {
            EventType = eventType;
            Status = EventStatus.AVALABLE;
            Power = random.Next(20, 90);
        }
    }
}
