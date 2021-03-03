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
        private Random random = new Random();

        public string Name { get; set; }
        public int FoodPrice { get; set; }

        public int FoodAmount { get; set; }
        public List<string> Destinations { get; set; }
        public List<string> Crewmembers { get; set; }
        public Dictionary<Cargo, HarborCargoItem> CargoInStock { get; set; }
        public Ship PlayerShip { get; private set; }

        public Harbor()
        {
            PlayerShip = Ship.GetInstance();
            CargoInStock = new Dictionary<Cargo, HarborCargoItem>();

            InitializeCargo();

            FoodAmount = random.Next(10, 400);
            FoodPrice = random.Next(1, 10);

            //new HarborScreen(this).Show();
        }

        public bool BuyFood(int amount)
        {
            int price = FoodPrice;

            if (PriceCheck(price * amount)) {
                if (FoodAmount - amount >= 0) {
                    FoodAmount -= amount;
                    PlayerShip.Money -= price * amount;
                    PlayerShip.Food += amount;
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool BuyCargo(Cargo cargo, int amount)
        {
            if (IsCargoInStock(cargo, amount)) 
            {
                int buyPrice = CargoInStock[cargo].buyPrice * amount;
                if (PriceCheck(buyPrice)) 
                {
                    Console.WriteLine("Sold Cargo");
                    PlayerShip.Cargo[cargo] += amount;
                    PlayerShip.Money -= buyPrice;
                    RemoveStock(cargo, amount);
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool SellCargo(Cargo cargo, int amount)
        {
            if (PlayerShip.Cargo[cargo] - amount >= 0) {
                PlayerShip.Cargo[cargo] -= amount;
                PlayerShip.Money += CargoInStock[cargo].sellPrice * amount;
                GainStock(cargo, amount);
                return true;
            }
            return false;
        }

        private bool IsCargoInStock(Cargo cargo, int amount) => CargoInStock[cargo].amount - amount >= 0;

        private void RemoveStock(Cargo cargo, int amount)
        {
            if (IsCargoInStock(cargo, amount)) {
                int newAmount = CargoInStock[cargo].amount - amount;
                CargoInStock[cargo] = new HarborCargoItem(newAmount, CargoInStock[cargo].buyPrice, CargoInStock[cargo].sellPrice);
            }
        }

        private void GainStock(Cargo cargo, int amount)
        {
            int newAmount = CargoInStock[cargo].amount + amount;
            CargoInStock[cargo] = new HarborCargoItem(newAmount, CargoInStock[cargo].buyPrice, CargoInStock[cargo].sellPrice);
        }

        public void BuyCrewmember(Crewmember crewmember)
        {
            if (PriceCheck(crewmember.Cost)) {
                PlayerShip.Money -= crewmember.Cost;
                PlayerShip.Crew.Add(crewmember);
            }
        }

        public HarborCargoItem GetCargoInStockItem(CargoTypes type)
        {
            foreach (KeyValuePair<Cargo, HarborCargoItem> kvp in CargoInStock) {
                if (kvp.Key.cargoType == type) return kvp.Value;
            }
            return new HarborCargoItem();
        }

        private bool PriceCheck(int cost) => (PlayerShip.Money - cost >= 0);

        private void InitializeCargo()
        {
            foreach (KeyValuePair<Cargo, int> item in PlayerShip.Cargo) {
                HarborCargoItem cargoItem = new HarborCargoItem(random.Next(0, 500), item.Key);
                CargoInStock.Add(item.Key, cargoItem);
            }
        }
    }

    public struct HarborCargoItem
    {
        public int amount;
        public int buyPrice;
        public int sellPrice;

        public HarborCargoItem(int amount, Cargo cargo)
        {
            this.amount = amount;
            buyPrice = cargo.GetBuyPrice();
            sellPrice = cargo.GetSellPrice();
        }

        public HarborCargoItem(int amount, int buyPrice, int sellPrice)
        {
            this.amount = amount;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
        }
    }
}
