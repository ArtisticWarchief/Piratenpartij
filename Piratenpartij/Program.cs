using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Piratenpartij.Obstacles;
using Piratenpartij.Obstacles.Enums;

namespace Piratenpartij
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Event e1 = new Event(Event.ObstacleType.HANDELSCHIP);
            //Console.WriteLine(e1.name);
            //List<Event> events = new List<Event>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Event e1 = EventMaker.GetRandomly();
            //    events.Add(e1);
            //}
            //Console.WriteLine(events.Where(e => e.EventType == EventType.PIRATES_SHIP).Count());
            // Trip trip = Trip.GetInstance(Location.US, Location.EU);

            new Trip(Location.AS, Location.US).Events.ForEach(e => Console.WriteLine($"{e.EventType}, {e.Power}, {e.Status}"));
        }
    }
}
