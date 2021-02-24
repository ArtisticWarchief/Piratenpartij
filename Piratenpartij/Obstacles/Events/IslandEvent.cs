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
        public Ship.Ship ship;

        public string islandName { get; set; }
        public string option { get; set; }
        
        public IslandEvent() : base(EventType.ISLAND)
        {
            Boolean goodOption = random.Next(0, 2) > 0;
            islandName = islandNames[random.Next(0, 7)];

            Console.WriteLine(goodOption + " " + islandName);

            if (goodOption) {
                option = goodOptions[random.Next(0, 2)];
                
            }
            else {
                option = badOptions[random.Next(0, 2)];
            }

            setShipAttributes(goodOption, islandName, option);
        }

        public void setShipAttributes(Boolean goodOption, string islandName, string option)
        {
            
        }
    }
}
