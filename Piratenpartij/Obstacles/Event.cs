using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Obstacles
{
    public class Event
    {
        
        public EventType EventType { get; set; }
        public int Difficulty { get; set; }

        static Random random = new Random();
        public Event(EventType eventType)
        {
            EventType = eventType;
            Difficulty = random.Next(10, 100);
        }
    }

    public class EventHandler
    {
        private EventHandler(){}

        public static EventHandler instance;

        public static EventHandler GetInstance()
        {
            if(instance == null)
            {
                instance = new EventHandler();
            }
            return instance;
        }

        public static bool IsSuccessful(Event e)
        {
            if(e.Difficulty > 75)
            {

            }
            return false;
        }
    }

    interface IMerchant    
    {
        void Ignore(Event e);
        void Trade(Event e);
        void Overcome(Event e);
    }
    interface IPirate
    {
        void FightBack(Event e);
        void Flee(Event e);
        void Satisfy(Event e);
    }

}
