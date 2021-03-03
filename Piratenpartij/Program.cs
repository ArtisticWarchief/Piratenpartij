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
            /**Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HarborTestUI());*/

            //new Trip(Location.AS, Location.US).Events.ForEach(e => Console.WriteLine($"{e.EventType}, {e.Power}, {e.Status}"));
        }
    }
}
