using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crewmembers;
using Piratenpartij.Cargos;
using Piratenpartij.Ships;

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
        public Ship PlayerShip { get; private set; }

        public Harbor()
        {
            InitializeCargo();
            InitializeCrewmembers();           
            FoodPrice = random.Next(1, 10);
            PlayerShip = Ship.GetInstance();
        }

        public void BuyFood(int amount, int price)
        {
            if (!PriceCheck(price)) {
                return;
            }

            PlayerShip.Food += amount;
           
        }

        public void BuyCargo(Cargo cargo, int amount)
        {
            if (!PriceCheck(cargo.Price)) {
                return;
            }

            foreach (Cargo cargoOnShip in PlayerShip.Cargo.Keys) {
                if (cargo.GetType() == cargoOnShip.GetType()) {
                    PlayerShip.Cargo[cargoOnShip] += amount;
                    break;
                }
            }           
            // dunno how this list gets represented in the UI, assuming its just a list of generic Cargo
            CargoInStock.FirstOrDefault(e => e.Key == cargo);

            CargoInStock.FirstOrDefault(e => e.Key.GetType() == typeof(Cargo));
        }

        public void SellCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void BuyCrewmember(Crewmember crewmember)
        {
            if (!PriceCheck(crewmember.Cost)){
                return;
            }

            PlayerShip.Money -= crewmember.Cost;
            PlayerShip.Crewmembers.Add(crewmember);
        }

        private bool PriceCheck(int cost)
        {
            if (PlayerShip.Money - cost < 0) {
                return false;
            }

            return true;
        }
        private void InitializeCargo()
        {
            // take cargo out of a text file or something idk
        }

        private void InitializeCrewmembers()
        {
            // take crew out of a text file or something idk
        }
    }
}
