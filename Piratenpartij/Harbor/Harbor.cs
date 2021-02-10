using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Cargo;

namespace Piratenpartij.Harbor
{
    class Harbor
    {
        private Ship ship;
        readonly Random random = new Random();

        public string Name { get; set; }
        public int FoodPrice { get; set; }
        public List<string> Destinations { get; set; }
        public List<string> Crewmembers { get; set; }
        public Dictionary<Cargo.Cargo, int> CargoInStock { get; set; }


        public Harbor(Ship ship)
        {
            InitializeCargo();
            InitializeCrewmembers();
            this.ship = ship;
            FoodPrice = random.Next(1, 10);
        }

        private void InitializeCargo()
        {

        }

        private void InitializeCrewmembers()
        {

        }
    }
}
