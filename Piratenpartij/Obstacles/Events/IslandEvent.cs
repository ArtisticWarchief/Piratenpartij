using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Ship;

namespace Piratenpartij.Obstacles
{
    //IslandEvent could happen whenever an island appears along a trip
    public class IslandEvent : Event
    {
        private string[] islandNames = { "Hawaii", "Madagaskar", "Malediven", "Australië", "Palawan", "Santorini", "Maderira", "Gili" };

        private string[] goodOptions = { "Peugeot208", "AMSPortfolio", "Gold"};
        private string[] badOptions = { "Disease", "Lion attack", "Earthquake" };

        readonly Random random = new Random();

        public string islandName { get; set; }

        public IslandAttributes islandAttributes { get; set; }

        //public Ship ship { get; set; }
        
        public IslandEvent() : base(EventType.ISLAND)
        {
            Boolean goodOption = random.Next(0, 2) > 0;
            islandName = islandNames[random.Next(0, 7)];

            Console.WriteLine(goodOption + " " + islandName);

            if (goodOption) {
                Console.WriteLine("GenerateGoodOptions " + goodOptions[random.Next(0, 2)]);
            }
            else {
                Console.WriteLine("GenerateBadOptions " + badOptions[random.Next(0, 2)]);
            }
        }
    }
}
