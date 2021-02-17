using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piratenpartij.Cargos;

namespace Piratenpartij.Harbors
{
   public class Harbor
    {      
        readonly Random random = new Random();

        public string Name { get; set; }
        public int FoodPrice { get; set; }
        public List<string> Destinations { get; set; }
        public List<string> Crewmembers { get; set; }
        public Dictionary<Cargo, int> CargoInStock { get; set; }


        public Harbor()
        {
            InitializeCargo();
            InitializeCrewmembers();           
            FoodPrice = random.Next(1, 10);
        }

        public void BuyFood()
        {
            throw new NotImplementedException();
        }

        public void BuyCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void SellCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void BuyCrewmember()
        {

        }

        private void InitializeCargo()
        {

        }

        private void InitializeCrewmembers()
        {

        }
    }
}
