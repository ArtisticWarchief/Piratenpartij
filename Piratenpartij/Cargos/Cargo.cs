using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenpartij.Cargos
{
    public abstract class Cargo
    {
        public string Name { get; set; }
        public int LimitOnShip { get; set; }

        protected int maximumBuyPrice, minimumBuyPrice;
        protected int maximumSellPrice, minimumSellPrice;

        public CargoTypes cargoType;

        public Cargo() { }

        public int GetSellPrice()
        {
            Random r = new Random();
            return r.Next(minimumBuyPrice, maximumBuyPrice);
        }

        public int GetBuyPrice()
        {
            Random r = new Random();
            return r.Next(minimumSellPrice, maximumSellPrice);
        }
    }
}

public enum CargoTypes
{
    Peugeot208,
    Mountain,
    Portofolio
}
