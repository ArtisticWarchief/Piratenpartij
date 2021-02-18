using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij
{
    class Island
    {
        private string[] islandNames = { "Hawaii", "Madagaskar", "Malediven", "Australië", "Palawan", "Santorini", "Maderira", "Gili" };

        private string[] goodOptions = { "banana", "gold", "cargo", "pork" };
        private string[] badOptions = { "disease", "lion attack", "earthquake" };

        readonly Random random = new Random();

        public string islandName { get; set; }

        public IslandAttributes islandAttributes { get; set; }

        public void GenerateIsland()
        {
            Console.WriteLine("test");
        }
    }
}
